namespace KhoaLinhAuto_App
{
    partial class frmMain
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
            this.btnAddKH = new System.Windows.Forms.Button();
            this.btnAddDH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddKH
            // 
            this.btnAddKH.Location = new System.Drawing.Point(140, 143);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(116, 61);
            this.btnAddKH.TabIndex = 0;
            this.btnAddKH.Text = "Thêm khách hàng";
            this.btnAddKH.UseVisualStyleBackColor = true;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnAddDH
            // 
            this.btnAddDH.Location = new System.Drawing.Point(140, 51);
            this.btnAddDH.Name = "btnAddDH";
            this.btnAddDH.Size = new System.Drawing.Size(111, 66);
            this.btnAddDH.TabIndex = 1;
            this.btnAddDH.Text = "Nhập đơn hàng";
            this.btnAddDH.UseVisualStyleBackColor = true;
            this.btnAddDH.Click += new System.EventHandler(this.btnAddDH_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddDH);
            this.Controls.Add(this.btnAddKH);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnAddDH;
        private System.Windows.Forms.Button button1;
    }
}