
namespace DoAnDesktopClient
{
    partial class MainForm
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
            this.btnSVMng = new System.Windows.Forms.Button();
            this.btnGVMng = new System.Windows.Forms.Button();
            this.btnDoAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSVMng
            // 
            this.btnSVMng.Location = new System.Drawing.Point(29, 98);
            this.btnSVMng.Name = "btnSVMng";
            this.btnSVMng.Size = new System.Drawing.Size(94, 78);
            this.btnSVMng.TabIndex = 0;
            this.btnSVMng.Text = "Quản lý tài khoản sinh viên";
            this.btnSVMng.UseVisualStyleBackColor = true;
            this.btnSVMng.Click += new System.EventHandler(this.btnSVMng_Click);
            // 
            // btnGVMng
            // 
            this.btnGVMng.Location = new System.Drawing.Point(260, 98);
            this.btnGVMng.Name = "btnGVMng";
            this.btnGVMng.Size = new System.Drawing.Size(94, 78);
            this.btnGVMng.TabIndex = 1;
            this.btnGVMng.Text = "Quản lý tài khoản giáo viên";
            this.btnGVMng.UseVisualStyleBackColor = true;
            this.btnGVMng.Click += new System.EventHandler(this.btnGVMng_Click);
            // 
            // btnDoAn
            // 
            this.btnDoAn.Location = new System.Drawing.Point(508, 98);
            this.btnDoAn.Name = "btnDoAn";
            this.btnDoAn.Size = new System.Drawing.Size(94, 78);
            this.btnDoAn.TabIndex = 2;
            this.btnDoAn.Text = "Quản lý đồ án sinh viên";
            this.btnDoAn.UseVisualStyleBackColor = true;
            this.btnDoAn.Click += new System.EventHandler(this.btnDoAn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 371);
            this.Controls.Add(this.btnDoAn);
            this.Controls.Add(this.btnGVMng);
            this.Controls.Add(this.btnSVMng);
            this.Name = "MainForm";
            this.Text = "Giao diện quản lý";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSVMng;
        private System.Windows.Forms.Button btnGVMng;
        private System.Windows.Forms.Button btnDoAn;
    }
}