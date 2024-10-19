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
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaiPhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsHoaDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDSHoaDon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
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
            this.dgvHoaDon.Location = new System.Drawing.Point(18, 56);
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
            this.dgvHoaDon.Size = new System.Drawing.Size(1095, 720);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.TabStop = false;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yourDataGridView_CellClick);
            this.dgvHoaDon.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvHoaDon_CellPainting);
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
            this.TenKhachHang.HeaderText = "Số điện thoại";
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
            // cmsHoaDon
            // 
            this.cmsHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmsHoaDon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemChiTiet,
            this.cmsItemXoa});
            this.cmsHoaDon.Name = "cmsXeMay";
            this.cmsHoaDon.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsHoaDon.Size = new System.Drawing.Size(113, 48);
            // 
            // cmsItemChiTiet
            // 
            this.cmsItemChiTiet.Name = "cmsItemChiTiet";
            this.cmsItemChiTiet.Size = new System.Drawing.Size(112, 22);
            this.cmsItemChiTiet.Text = "Chi tiết";
            this.cmsItemChiTiet.Click += new System.EventHandler(this.cmsItemChiTiet_Click);
            // 
            // cmsItemXoa
            // 
            this.cmsItemXoa.Name = "cmsItemXoa";
            this.cmsItemXoa.Size = new System.Drawing.Size(112, 22);
            this.cmsItemXoa.Text = "Xóa";
            this.cmsItemXoa.Click += new System.EventHandler(this.cmsItemXoa_Click);
            // 
            // panelDSHoaDon
            // 
            this.panelDSHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.panelDSHoaDon.Controls.Add(this.label2);
            this.panelDSHoaDon.Controls.Add(this.dgvHoaDon);
            this.panelDSHoaDon.Location = new System.Drawing.Point(27, 18);
            this.panelDSHoaDon.Name = "panelDSHoaDon";
            this.panelDSHoaDon.Size = new System.Drawing.Size(1130, 833);
            this.panelDSHoaDon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(59, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 869);
            this.Controls.Add(this.panelDSHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHoaDon";
            this.Text = "fHoaDon";
            this.Load += new System.EventHandler(this.fHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.cmsHoaDon.ResumeLayout(false);
            this.panelDSHoaDon.ResumeLayout(false);
            this.panelDSHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ContextMenuStrip cmsHoaDon;
        private System.Windows.Forms.Panel panelDSHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cmsItemChiTiet;
        private System.Windows.Forms.ToolStripMenuItem cmsItemXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaiPhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}