namespace WindowsFormsApp1
{
    partial class fTableManager
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
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBilll = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotolPrice = new System.Windows.Forms.TextBox();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.chuyenBna = new System.Windows.Forms.Button();
            this.phanTramgiam = new System.Windows.Forms.NumericUpDown();
            this.GiamGia = new System.Windows.Forms.Button();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btThemDV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phanTramgiam)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpRoom);
            this.panel1.Location = new System.Drawing.Point(17, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 687);
            this.panel1.TabIndex = 0;
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.Location = new System.Drawing.Point(5, 3);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(543, 673);
            this.flpRoom.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            this.aDMINToolStripMenuItem.Click += new System.EventHandler(this.aDMINToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.đăngXuấtToolStripMenuItem.Text = "đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBilll);
            this.panel2.Location = new System.Drawing.Point(569, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 527);
            this.panel2.TabIndex = 2;
            // 
            // lsvBilll
            // 
            this.lsvBilll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBilll.GridLines = true;
            this.lsvBilll.HideSelection = false;
            this.lsvBilll.Location = new System.Drawing.Point(0, 3);
            this.lsvBilll.Name = "lsvBilll";
            this.lsvBilll.Size = new System.Drawing.Size(516, 521);
            this.lsvBilll.TabIndex = 0;
            this.lsvBilll.UseCompatibleStateImageBehavior = false;
            this.lsvBilll.View = System.Windows.Forms.View.Details;
            this.lsvBilll.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 141;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotolPrice);
            this.panel3.Controls.Add(this.cbbPhong);
            this.panel3.Controls.Add(this.chuyenBna);
            this.panel3.Controls.Add(this.phanTramgiam);
            this.panel3.Controls.Add(this.GiamGia);
            this.panel3.Controls.Add(this.btCheckOut);
            this.panel3.Location = new System.Drawing.Point(569, 644);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 74);
            this.panel3.TabIndex = 3;
            // 
            // txbTotolPrice
            // 
            this.txbTotolPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTotolPrice.ForeColor = System.Drawing.Color.Red;
            this.txbTotolPrice.Location = new System.Drawing.Point(259, 23);
            this.txbTotolPrice.Name = "txbTotolPrice";
            this.txbTotolPrice.ReadOnly = true;
            this.txbTotolPrice.Size = new System.Drawing.Size(141, 28);
            this.txbTotolPrice.TabIndex = 7;
            this.txbTotolPrice.Text = "0";
            this.txbTotolPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTotolPrice.TextChanged += new System.EventHandler(this.txbTotolPrice_TextChanged);
            // 
            // cbbPhong
            // 
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(5, 39);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(134, 24);
            this.cbbPhong.TabIndex = 4;
            // 
            // chuyenBna
            // 
            this.chuyenBna.Location = new System.Drawing.Point(3, 3);
            this.chuyenBna.Name = "chuyenBna";
            this.chuyenBna.Size = new System.Drawing.Size(136, 32);
            this.chuyenBna.TabIndex = 6;
            this.chuyenBna.Text = "Đặt Phòng";
            this.chuyenBna.UseVisualStyleBackColor = true;
            // 
            // phanTramgiam
            // 
            this.phanTramgiam.Location = new System.Drawing.Point(145, 39);
            this.phanTramgiam.Name = "phanTramgiam";
            this.phanTramgiam.Size = new System.Drawing.Size(101, 22);
            this.phanTramgiam.TabIndex = 4;
            this.phanTramgiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GiamGia
            // 
            this.GiamGia.Location = new System.Drawing.Point(145, 3);
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.Size = new System.Drawing.Size(101, 32);
            this.GiamGia.TabIndex = 5;
            this.GiamGia.Text = "Giảm Giá";
            this.GiamGia.UseVisualStyleBackColor = true;
            // 
            // btCheckOut
            // 
            this.btCheckOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCheckOut.Location = new System.Drawing.Point(406, 0);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(101, 71);
            this.btCheckOut.TabIndex = 4;
            this.btCheckOut.Text = "Thanh Toán";
            this.btCheckOut.UseVisualStyleBackColor = true;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btThemDV);
            this.panel4.Location = new System.Drawing.Point(571, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 62);
            this.panel4.TabIndex = 4;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(4, 33);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(240, 24);
            this.cbFood.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(4, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(240, 24);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(373, 20);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(120, 22);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btThemDV
            // 
            this.btThemDV.Location = new System.Drawing.Point(257, 3);
            this.btThemDV.Name = "btThemDV";
            this.btThemDV.Size = new System.Drawing.Size(101, 54);
            this.btThemDV.TabIndex = 2;
            this.btThemDV.Text = "Thêm ";
            this.btThemDV.UseVisualStyleBackColor = true;
            this.btThemDV.Click += new System.EventHandler(this.btThemDV_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 755);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.Text = "Quản Lý Quán Karaoke";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phanTramgiam)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBilll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.Button chuyenBna;
        private System.Windows.Forms.NumericUpDown phanTramgiam;
        private System.Windows.Forms.Button GiamGia;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btThemDV;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotolPrice;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}