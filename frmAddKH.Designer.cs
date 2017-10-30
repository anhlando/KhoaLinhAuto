namespace KhoaLinhAuto_App
{
    partial class frmAddKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //parent form
        private frmMain myparent = null;

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
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDT1 = new System.Windows.Forms.TextBox();
            this.txtDiachi1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(132, 34);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(132, 79);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtDT1
            // 
            this.txtDT1.Location = new System.Drawing.Point(132, 131);
            this.txtDT1.Name = "txtDT1";
            this.txtDT1.Size = new System.Drawing.Size(100, 20);
            this.txtDT1.TabIndex = 2;
            // 
            // txtDiachi1
            // 
            this.txtDiachi1.Location = new System.Drawing.Point(132, 185);
            this.txtDiachi1.Name = "txtDiachi1";
            this.txtDiachi1.Size = new System.Drawing.Size(100, 20);
            this.txtDiachi1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmAddKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDiachi1);
            this.Controls.Add(this.txtDT1);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Name = "frmAddKH";
            this.Text = "Thêm khách hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddKH_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDT1;
        private System.Windows.Forms.TextBox txtDiachi1;
        private System.Windows.Forms.Button button1;

    }
}

