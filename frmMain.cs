using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhoaLinhAuto_App.DonHang_WS;

namespace KhoaLinhAuto_App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            frmAddKH _frmAddKH = new frmAddKH(this);
            _frmAddKH.Show();
            
        }

        private void btnAddDH_Click(object sender, EventArgs e)
        {
            frmAddDH _frmAddDH = new frmAddDH(this);
            _frmAddDH.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            donhang_WS dhWS = new donhang_WS();
            MessageBox.Show(dhWS.generateMaDH("1"));

        }
    }
}
