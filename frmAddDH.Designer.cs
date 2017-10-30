namespace KhoaLinhAuto_App
{
    partial class frmAddDH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.layoutCTDH = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.lblTienloi = new System.Windows.Forms.Label();
            this.txtTienloi = new System.Windows.Forms.TextBox();
            this.chkDathanhtoan = new System.Windows.Forms.CheckBox();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.lblNgaylap = new System.Windows.Forms.Label();
            this.txtTongTienOld = new System.Windows.Forms.TextBox();
            this.txtQueryDH = new System.Windows.Forms.TextBox();
            this.txtTienloiOld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(87, 26);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(121, 22);
            this.cmbKhachHang.TabIndex = 0;
            
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(13, 32);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(68, 14);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 72);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // layoutCTDH
            // 
            this.layoutCTDH.AutoSize = true;
            this.layoutCTDH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutCTDH.ColumnCount = 1;
            this.layoutCTDH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCTDH.Location = new System.Drawing.Point(16, 100);
            this.layoutCTDH.Name = "layoutCTDH";
            this.layoutCTDH.RowCount = 1;
            this.layoutCTDH.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutCTDH.Size = new System.Drawing.Size(0, 0);
            this.layoutCTDH.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(909, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(570, 76);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(54, 14);
            this.lblTongtien.TabIndex = 5;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(624, 69);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(100, 20);
            this.txtTongtien.TabIndex = 6;
            this.txtTongtien.Text = "0";
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtTongtien_TextChanged);
            // 
            // lblTienloi
            // 
            this.lblTienloi.AutoSize = true;
            this.lblTienloi.Location = new System.Drawing.Point(733, 76);
            this.lblTienloi.Name = "lblTienloi";
            this.lblTienloi.Size = new System.Drawing.Size(44, 14);
            this.lblTienloi.TabIndex = 7;
            this.lblTienloi.Text = "Tiền lời:";
            // 
            // txtTienloi
            // 
            this.txtTienloi.Location = new System.Drawing.Point(778, 69);
            this.txtTienloi.Name = "txtTienloi";
            this.txtTienloi.ReadOnly = true;
            this.txtTienloi.Size = new System.Drawing.Size(100, 20);
            this.txtTienloi.TabIndex = 8;
            this.txtTienloi.Text = "0";
            // 
            // chkDathanhtoan
            // 
            this.chkDathanhtoan.AutoSize = true;
            this.chkDathanhtoan.Location = new System.Drawing.Point(455, 75);
            this.chkDathanhtoan.Name = "chkDathanhtoan";
            this.chkDathanhtoan.Size = new System.Drawing.Size(94, 18);
            this.chkDathanhtoan.TabIndex = 9;
            this.chkDathanhtoan.Text = "Đã thanh toán";
            this.chkDathanhtoan.UseVisualStyleBackColor = true;
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylap.Location = new System.Drawing.Point(330, 71);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(93, 20);
            this.dtpNgaylap.TabIndex = 10;
            
            // 
            // lblNgaylap
            // 
            this.lblNgaylap.AutoSize = true;
            this.lblNgaylap.Location = new System.Drawing.Point(275, 76);
            this.lblNgaylap.Name = "lblNgaylap";
            this.lblNgaylap.Size = new System.Drawing.Size(52, 14);
            this.lblNgaylap.TabIndex = 11;
            this.lblNgaylap.Text = "Ngày lập:";
            // 
            // txtTongTienOld
            // 
            this.txtTongTienOld.Location = new System.Drawing.Point(624, 43);
            this.txtTongTienOld.Name = "txtTongTienOld";
            this.txtTongTienOld.ReadOnly = true;
            this.txtTongTienOld.Size = new System.Drawing.Size(100, 20);
            this.txtTongTienOld.TabIndex = 12;
            this.txtTongTienOld.Text = "0";
            this.txtTongTienOld.Visible = false;
            // 
            // txtQueryDH
            // 
            this.txtQueryDH.Location = new System.Drawing.Point(778, 16);
            this.txtQueryDH.Name = "txtQueryDH";
            this.txtQueryDH.ReadOnly = true;
            this.txtQueryDH.Size = new System.Drawing.Size(100, 20);
            this.txtQueryDH.TabIndex = 13;
            this.txtQueryDH.Visible = false;
            // 
            // txtTienloiOld
            // 
            this.txtTienloiOld.Location = new System.Drawing.Point(778, 42);
            this.txtTienloiOld.Name = "txtTienloiOld";
            this.txtTienloiOld.ReadOnly = true;
            this.txtTienloiOld.Size = new System.Drawing.Size(100, 20);
            this.txtTienloiOld.TabIndex = 14;
            this.txtTienloiOld.Text = "0";
            this.txtTienloiOld.Visible = false;
            // 
            // frmAddDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 356);
            this.Controls.Add(this.txtTienloiOld);
            this.Controls.Add(this.txtQueryDH);
            this.Controls.Add(this.txtTongTienOld);
            this.Controls.Add(this.lblNgaylap);
            this.Controls.Add(this.dtpNgaylap);
            this.Controls.Add(this.chkDathanhtoan);
            this.Controls.Add(this.txtTienloi);
            this.Controls.Add(this.lblTienloi);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.layoutCTDH);
            this.Name = "frmAddDH";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddDH_FormClosed);
            this.Load += new System.EventHandler(this.frmAddDH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel layoutCTDH;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label lblTienloi;
        private System.Windows.Forms.TextBox txtTienloi;
        private System.Windows.Forms.CheckBox chkDathanhtoan;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private System.Windows.Forms.Label lblNgaylap;
        private System.Windows.Forms.TextBox txtTongTienOld;
        private System.Windows.Forms.TextBox txtQueryDH;
        private System.Windows.Forms.TextBox txtTienloiOld;
    }
}