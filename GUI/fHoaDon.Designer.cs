namespace GUI
{
    partial class fHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNhapHoaDon = new GUI.CustomDesign.CustomButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDSHoaDon = new GUI.CustomDesign.CustomButton();
            this.cmsHoaDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemSua = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDSHoaDon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaiPhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.cmsHoaDon.SuspendLayout();
            this.panelDSHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToResizeColumns = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.TenKhachHang,
            this.MaNhanVien,
            this.NgayIn,
            this.GiaiPhap,
            this.ThanhTien});
            this.dgvHoaDon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHoaDon.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvHoaDon.Location = new System.Drawing.Point(19, 66);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 30;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1060, 632);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.TabStop = false;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yourDataGridView_CellClick);
            this.dgvHoaDon.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvHoaDon_CellPainting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbOrder);
            this.panel2.Location = new System.Drawing.Point(48, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 56);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.AllowDrop = true;
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "All Orders",
            "Order1",
            "Order2"});
            this.cmbOrder.Location = new System.Drawing.Point(64, 16);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(108, 29);
            this.cmbOrder.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnNhapHoaDon);
            this.panel3.Location = new System.Drawing.Point(973, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 56);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::GUI.Properties.Resources.file_download;
            this.pictureBox3.Location = new System.Drawing.Point(11, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnNhapHoaDon
            // 
            this.btnNhapHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.btnNhapHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnNhapHoaDon.BorderColor = System.Drawing.Color.Empty;
            this.btnNhapHoaDon.BorderThickness = 1.5F;
            this.btnNhapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHoaDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHoaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNhapHoaDon.Location = new System.Drawing.Point(3, 3);
            this.btnNhapHoaDon.Name = "btnNhapHoaDon";
            this.btnNhapHoaDon.Size = new System.Drawing.Size(157, 50);
            this.btnNhapHoaDon.TabIndex = 4;
            this.btnNhapHoaDon.Text = "Nhập hóa đơn";
            this.btnNhapHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapHoaDon.UseVisualStyleBackColor = false;
            this.btnNhapHoaDon.Click += new System.EventHandler(this.btnNhapHoaDon_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::GUI.Properties.Resources.address_book;
            this.pictureBox4.Location = new System.Drawing.Point(13, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.btnDSHoaDon);
            this.panel4.Location = new System.Drawing.Point(792, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 56);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnDSHoaDon
            // 
            this.btnDSHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.btnDSHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnDSHoaDon.BorderColor = System.Drawing.Color.Empty;
            this.btnDSHoaDon.BorderThickness = 1.5F;
            this.btnDSHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSHoaDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHoaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDSHoaDon.Location = new System.Drawing.Point(3, 3);
            this.btnDSHoaDon.Name = "btnDSHoaDon";
            this.btnDSHoaDon.Size = new System.Drawing.Size(147, 50);
            this.btnDSHoaDon.TabIndex = 3;
            this.btnDSHoaDon.Text = "DS hóa đơn";
            this.btnDSHoaDon.UseVisualStyleBackColor = false;
            this.btnDSHoaDon.Click += new System.EventHandler(this.btnDSHoaDon_Click);
            // 
            // cmsHoaDon
            // 
            this.cmsHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmsHoaDon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemChiTiet,
            this.cmsItemSua,
            this.cmsItemXoa});
            this.cmsHoaDon.Name = "cmsXeMay";
            this.cmsHoaDon.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsHoaDon.Size = new System.Drawing.Size(126, 76);
            // 
            // cmsItemChiTiet
            // 
            this.cmsItemChiTiet.Name = "cmsItemChiTiet";
            this.cmsItemChiTiet.Size = new System.Drawing.Size(125, 24);
            this.cmsItemChiTiet.Text = "Chi tiết";
            // 
            // cmsItemSua
            // 
            this.cmsItemSua.Name = "cmsItemSua";
            this.cmsItemSua.Size = new System.Drawing.Size(125, 24);
            this.cmsItemSua.Text = "Sửa";
            this.cmsItemSua.Click += new System.EventHandler(this.cmsItemSua_Click);
            // 
            // cmsItemXoa
            // 
            this.cmsItemXoa.Name = "cmsItemXoa";
            this.cmsItemXoa.Size = new System.Drawing.Size(125, 24);
            this.cmsItemXoa.Text = "Xóa";
            this.cmsItemXoa.Click += new System.EventHandler(this.cmsItemXoa_Click);
            // 
            // panelDSHoaDon
            // 
            this.panelDSHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.panelDSHoaDon.Controls.Add(this.label2);
            this.panelDSHoaDon.Controls.Add(this.dgvHoaDon);
            this.panelDSHoaDon.Location = new System.Drawing.Point(48, 118);
            this.panelDSHoaDon.Name = "panelDSHoaDon";
            this.panelDSHoaDon.Size = new System.Drawing.Size(1088, 725);
            this.panelDSHoaDon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(59, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            this.MaHoaDon.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Mã khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 125;
            // 
            // NgayIn
            // 
            this.NgayIn.HeaderText = "Ngày in";
            this.NgayIn.MinimumWidth = 6;
            this.NgayIn.Name = "NgayIn";
            this.NgayIn.ReadOnly = true;
            this.NgayIn.Width = 125;
            // 
            // GiaiPhap
            // 
            this.GiaiPhap.HeaderText = "Giải pháp";
            this.GiaiPhap.MinimumWidth = 6;
            this.GiaiPhap.Name = "GiaiPhap";
            this.GiaiPhap.ReadOnly = true;
            this.GiaiPhap.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 125;
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 869);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelDSHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHoaDon";
            this.Text = "fHoaDon";
            this.Load += new System.EventHandler(this.fHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.cmsHoaDon.ResumeLayout(false);
            this.panelDSHoaDon.ResumeLayout(false);
            this.panelDSHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CustomDesign.CustomButton btnNhapHoaDon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomDesign.CustomButton btnDSHoaDon;
        private System.Windows.Forms.ContextMenuStrip cmsHoaDon;
        private System.Windows.Forms.Panel panelDSHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cmsItemChiTiet;
        private System.Windows.Forms.ToolStripMenuItem cmsItemSua;
        private System.Windows.Forms.ToolStripMenuItem cmsItemXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaiPhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}