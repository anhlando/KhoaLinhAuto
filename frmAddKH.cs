using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhoaLinhAuto_App.KhachHang_WS;
using KhoaLinhAuto_App.SanPham_WS;

namespace KhoaLinhAuto_App
{
    public partial class frmAddKH : Form
    {
        public frmAddKH(frmMain parent)
        {
            this.myparent = parent;
            myparent.Hide();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtMaKH.Text;
            /*khachhang_WS khWS = new khachhang_WS();

            sanpham_WS spWS = new sanpham_WS();

            KhachHang[] dsKH;
            SanPham[] dsSP;

            dsKH = khWS.getKH(id);
            dsSP = spWS.getSP(id);*/

            StringBuilder sb = new StringBuilder();
            CommonFunction function = new CommonFunction();
            List<KhachHangDO> dsKH = function.getKH(id);
            

            foreach (KhachHangDO kh in dsKH )
            {
                
                sb.AppendLine(kh.TenKH);
            }

            MessageBox.Show(sb.ToString());
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbSP.Items.Add(
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CommonFunction function = new CommonFunction();
            try
            {
                function.addKH(new KhachHangDO(txtMaKH.Text, txtTenKH.Text, txtDT1.Text, "", "", "", txtDiachi1.Text, ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            myparent.Show();
        }
    }
}
