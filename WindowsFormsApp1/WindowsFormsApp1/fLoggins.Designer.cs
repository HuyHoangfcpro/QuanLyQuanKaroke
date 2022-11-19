namespace WindowsFormsApp1
{
    partial class fLoggins
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOut = new System.Windows.Forms.Button();
            this.btloggin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.UsePass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUseName = new System.Windows.Forms.TextBox();
            this.useName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btOut);
            this.panel1.Controls.Add(this.btloggin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 215);
            this.panel1.TabIndex = 0;
            // 
            // btOut
            // 
            this.btOut.ForeColor = System.Drawing.Color.Black;
            this.btOut.ImageKey = "(none)";
            this.btOut.Location = new System.Drawing.Point(341, 151);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(87, 44);
            this.btOut.TabIndex = 3;
            this.btOut.Text = "Thoát";
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click_1);
            // 
            // btloggin
            // 
            this.btloggin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btloggin.ForeColor = System.Drawing.Color.Black;
            this.btloggin.Location = new System.Drawing.Point(199, 151);
            this.btloggin.Name = "btloggin";
            this.btloggin.Size = new System.Drawing.Size(112, 45);
            this.btloggin.TabIndex = 1;
            this.btloggin.Text = "đăng nhập";
            this.btloggin.UseVisualStyleBackColor = true;
            this.btloggin.Click += new System.EventHandler(this.btloggin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPass);
            this.panel3.Controls.Add(this.UsePass);
            this.panel3.Location = new System.Drawing.Point(3, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 49);
            this.panel3.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbPass.Location = new System.Drawing.Point(172, 11);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(253, 22);
            this.tbPass.TabIndex = 1;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // UsePass
            // 
            this.UsePass.AutoSize = true;
            this.UsePass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UsePass.ForeColor = System.Drawing.Color.Black;
            this.UsePass.Location = new System.Drawing.Point(3, 8);
            this.UsePass.Name = "UsePass";
            this.UsePass.Size = new System.Drawing.Size(107, 24);
            this.UsePass.TabIndex = 0;
            this.UsePass.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbUseName);
            this.panel2.Controls.Add(this.useName);
            this.panel2.Location = new System.Drawing.Point(3, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 49);
            this.panel2.TabIndex = 0;
            // 
            // tbUseName
            // 
            this.tbUseName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbUseName.Location = new System.Drawing.Point(172, 11);
            this.tbUseName.Name = "tbUseName";
            this.tbUseName.Size = new System.Drawing.Size(253, 22);
            this.tbUseName.TabIndex = 1;
            // 
            // useName
            // 
            this.useName.AutoSize = true;
            this.useName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.useName.ForeColor = System.Drawing.Color.Black;
            this.useName.Location = new System.Drawing.Point(3, 11);
            this.useName.Name = "useName";
            this.useName.Size = new System.Drawing.Size(163, 24);
            this.useName.TabIndex = 0;
            this.useName.Text = "Tên Đăng Nhập:";
            // 
            // fLoggins
            // 
            this.AcceptButton = this.btloggin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btloggin;
            this.ClientSize = new System.Drawing.Size(478, 238);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "fLoggins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLoggins_FormClosing);
            this.Load += new System.EventHandler(this.fLoggins_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label UsePass;
        private System.Windows.Forms.TextBox tbUseName;
        private System.Windows.Forms.Label useName;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btloggin;
    }
}

