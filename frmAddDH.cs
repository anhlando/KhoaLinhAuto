using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoaLinhAuto_App
{
    public partial class frmAddDH : Form
    {
        private List<KhachHangDO> dsKH = new List<KhachHangDO>();
        private frmMain myparent = null;
        private string maDH;
        private CommonFunction function = new CommonFunction();
        private List<ucCTDH> dsCTDH = new List<ucCTDH>();
        private List<SanPhamDO> dsSP = new List<SanPhamDO>();
        private int idCTDH = 1;

        public frmAddDH(frmMain parent)
        {
            myparent = parent;
            InitializeComponent();
            myparent.Hide();
            maDH = function.generateMaDH();

        }

        private void frmAddDH_Load(object sender, EventArgs e)
        {
            
            dsKH = function.getKH("all");

            dsSP = function.getSP("all");

            this.loadDSKHintoCombobox(cmbKhachHang, dsKH);
            AutoCompleteStringCollection dsKHSource = new AutoCompleteStringCollection();
            fillDSKHSource(dsKHSource,dsKH);
            cmbKhachHang.AutoCompleteCustomSource = dsKHSource;

            ucCTDH CTDH = new ucCTDH(maDH,dsSP,idCTDH);
            CTDH.ButtonClick += new EventHandler(deleteUCCTDH);
            CTDH.ChangeThanhTien += new EventHandler(calTongTien);
            dsCTDH.Add(CTDH);
            layoutCTDH.Controls.Add(CTDH);
        }

        private void fillDSKHSource(AutoCompleteStringCollection source, List<KhachHangDO> dsKH) 
        {
            try
            {
                foreach (KhachHangDO kh in dsKH)
                {
                    source.Add(kh.TenKH);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void loadDSKHintoCombobox(ComboBox cmb, List<KhachHangDO> dskh)
        {
            try
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                //loop through the list and bind to combobox
                foreach (KhachHangDO kh in dskh)
                {
                    //cmb.Items.Add();
                    
                    dict.Add(kh.MaKH, kh.TenKH);
                }

                cmb.DataSource = new BindingSource(dict, null);
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmAddDH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.myparent.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            idCTDH++;
            ucCTDH ctdh = new ucCTDH(maDH,dsSP,idCTDH);
            ctdh.ButtonClick += new EventHandler(deleteUCCTDH);
            ctdh.ChangeThanhTien += new EventHandler(calTongTien);
            dsCTDH.Add(ctdh);
            layoutCTDH.Controls.Add(ctdh);
        }

        private void deleteUCCTDH(object sender, EventArgs e)
        {
            //remove uc ra khoi List & layout
            ucCTDH uc = (ucCTDH)sender;
            int id = uc.ID;
            dsCTDH.Remove(dsCTDH.Find(x => x.ID == id));
            layoutCTDH.Controls.Remove((ucCTDH)sender);
            
            //re-calculate tongtien & tienloi
            caltt();
        }

        private void calTongTien(object sender, EventArgs e)
        {
            //sum(dsCTDH.Thanhtien)
            caltt();
            
        }

        private void caltt()
        {
            int tongtien = 0;
            int tienloi = 0;
            foreach (ucCTDH ctdh in dsCTDH)
            {
                tongtien += ctdh.ThanhTien;
                tienloi += ctdh.TienLoi;
            }
            txtTongTienOld.Text = tongtien.ToString();
            txtTongtien.Text = tongtien.ToString();
            txtTienloi.Text = tienloi.ToString();
            txtTienloiOld.Text = tienloi.ToString();
        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
            int oldTT = Convert.ToInt32(txtTongTienOld.Text);
            int newTT = Convert.ToInt32(txtTongtien.Text);
            int chenhlech = oldTT - newTT;
            int oldTL = Convert.ToInt32(txtTienloiOld.Text);
            int tl = oldTL - chenhlech;
            txtTienloi.Text = tl.ToString();
            updateQueryDH();
        }

        private void updateQueryDH()
        {
            
            KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)cmbKhachHang.SelectedItem;
            int dathanhtoan = chkDathanhtoan.Checked == true ? 1 : 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Donhang VALUES (");
            sb.Append("'" + maDH + "',");
            sb.Append("'" + kvp.Key + "',");
            sb.Append("'" + dtpNgaylap.Value.ToShortDateString() + "',");
            sb.Append(txtTongtien.Text + ",");
            sb.Append(txtTienloi.Text + ",");
            sb.Append(dathanhtoan);
            sb.Append(")");

            txtQueryDH.Text = sb.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateQueryDH();
            insertDonhang();
            insertCTDH();
            MessageBox.Show(txtQueryDH.Text);
        }

        private void insertDonhang()
        {
            try
            {
                bool result = function.insert(txtQueryDH.Text);
                if (result == false)
                {
                    throw new Exception("Insert Donhang failed!!!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void insertCTDH()
        {
            try
            {
                //loop through the list of ucCTDH and execute every query
                foreach (ucCTDH item in dsCTDH)
                {
                    bool result = function.insert(item.QueryValue);
                    if (result == false)
                    {
                        throw new Exception("Insert CTDH failed!!! CTDH id = " + item.ID.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
