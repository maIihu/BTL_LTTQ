namespace GUI
{
    partial class fKhachHang
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtSearchBar = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmsKhachHang = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.lbNext = new System.Windows.Forms.Label();
			this.dgvKhachHang = new System.Windows.Forms.DataGridView();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbPrevious = new System.Windows.Forms.Label();
			this.lbPage = new System.Windows.Forms.Label();
			this.panelAddNew = new System.Windows.Forms.Panel();
			this.btnUpdate = new GUI.CustomDesign.CustomButton();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnExitPanel = new System.Windows.Forms.Button();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.cmsKhachHang.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			this.panel1.SuspendLayout();
			this.panelAddNew.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Control;
			this.panel5.Controls.Add(this.txtSearchBar);
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Location = new System.Drawing.Point(18, 18);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1094, 56);
			this.panel5.TabIndex = 0;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
			// 
			// txtSearchBar
			// 
			this.txtSearchBar.BackColor = System.Drawing.SystemColors.Control;
			this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchBar.ForeColor = System.Drawing.SystemColors.GrayText;
			this.txtSearchBar.Location = new System.Drawing.Point(45, 17);
			this.txtSearchBar.Name = "txtSearchBar";
			this.txtSearchBar.Size = new System.Drawing.Size(1031, 22);
			this.txtSearchBar.TabIndex = 1;
			this.txtSearchBar.Text = "Tìm kiếm...";
			this.txtSearchBar.WordWrap = false;
			this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
			this.txtSearchBar.Enter += new System.EventHandler(this.txtSearchBar_Enter);
			this.txtSearchBar.Leave += new System.EventHandler(this.txtSearchBar_Leave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_search_32;
			this.pictureBox1.Location = new System.Drawing.Point(12, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(27, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// cmsKhachHang
			// 
			this.cmsKhachHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.cmsKhachHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
			this.cmsKhachHang.Name = "cmsXeMay";
			this.cmsKhachHang.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.cmsKhachHang.Size = new System.Drawing.Size(181, 70);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem1.Text = "Cập nhật";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.Update_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem2.Text = "Xóa";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.Delete_Click);
			// 
			// lbNext
			// 
			this.lbNext.AutoSize = true;
			this.lbNext.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNext.ForeColor = System.Drawing.SystemColors.GrayText;
			this.lbNext.Location = new System.Drawing.Point(588, 760);
			this.lbNext.Name = "lbNext";
			this.lbNext.Size = new System.Drawing.Size(25, 25);
			this.lbNext.TabIndex = 21;
			this.lbNext.Text = ">";
			this.lbNext.Click += new System.EventHandler(this.lbNext_Click);
			// 
			// dgvKhachHang
			// 
			this.dgvKhachHang.AllowUserToAddRows = false;
			this.dgvKhachHang.AllowUserToDeleteRows = false;
			this.dgvKhachHang.AllowUserToResizeColumns = false;
			this.dgvKhachHang.AllowUserToResizeRows = false;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
			this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SDT});
			this.dgvKhachHang.GridColor = System.Drawing.SystemColors.Control;
			this.dgvKhachHang.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.dgvKhachHang.Location = new System.Drawing.Point(17, 227);
			this.dgvKhachHang.MultiSelect = false;
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.ReadOnly = true;
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
			this.dgvKhachHang.RowHeadersVisible = false;
			this.dgvKhachHang.RowHeadersWidth = 51;
			this.dgvKhachHang.RowTemplate.Height = 30;
			this.dgvKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvKhachHang.Size = new System.Drawing.Size(1096, 520);
			this.dgvKhachHang.TabIndex = 2;
			this.dgvKhachHang.TabStop = false;
			this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
			this.dgvKhachHang.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvKhachHang_CellPainting);
			// 
			// MaKH
			// 
			this.MaKH.HeaderText = "Mã khách hàng";
			this.MaKH.Name = "MaKH";
			this.MaKH.ReadOnly = true;
			// 
			// TenKH
			// 
			this.TenKH.HeaderText = "Tên khách hàng";
			this.TenKH.Name = "TenKH";
			this.TenKH.ReadOnly = true;
			// 
			// DiaChi
			// 
			this.DiaChi.HeaderText = "Địa chỉ";
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.ReadOnly = true;
			// 
			// SDT
			// 
			this.SDT.HeaderText = "Số điện thoại";
			this.SDT.Name = "SDT";
			this.SDT.ReadOnly = true;
			// 
			// txtSDT
			// 
			this.txtSDT.BackColor = System.Drawing.SystemColors.Control;
			this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSDT.Location = new System.Drawing.Point(14, 8);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(394, 22);
			this.txtSDT.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.lbNext);
			this.panel1.Controls.Add(this.lbPrevious);
			this.panel1.Controls.Add(this.lbPage);
			this.panel1.Controls.Add(this.panelAddNew);
			this.panel1.Controls.Add(this.dgvKhachHang);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Location = new System.Drawing.Point(27, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1130, 800);
			this.panel1.TabIndex = 4;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// lbPrevious
			// 
			this.lbPrevious.AutoSize = true;
			this.lbPrevious.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPrevious.ForeColor = System.Drawing.SystemColors.GrayText;
			this.lbPrevious.Location = new System.Drawing.Point(518, 760);
			this.lbPrevious.Name = "lbPrevious";
			this.lbPrevious.Size = new System.Drawing.Size(25, 25);
			this.lbPrevious.TabIndex = 20;
			this.lbPrevious.Text = "<";
			this.lbPrevious.Click += new System.EventHandler(this.lbPrevious_Click);
			// 
			// lbPage
			// 
			this.lbPage.AutoSize = true;
			this.lbPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPage.ForeColor = System.Drawing.SystemColors.GrayText;
			this.lbPage.Location = new System.Drawing.Point(549, 762);
			this.lbPage.Name = "lbPage";
			this.lbPage.Size = new System.Drawing.Size(35, 21);
			this.lbPage.TabIndex = 14;
			this.lbPage.Text = "1/11";
			// 
			// panelAddNew
			// 
			this.panelAddNew.Controls.Add(this.btnExitPanel);
			this.panelAddNew.Controls.Add(this.btnUpdate);
			this.panelAddNew.Controls.Add(this.panel9);
			this.panelAddNew.Controls.Add(this.label2);
			this.panelAddNew.Controls.Add(this.panel7);
			this.panelAddNew.Controls.Add(this.label3);
			this.panelAddNew.Controls.Add(this.label4);
			this.panelAddNew.Controls.Add(this.panel8);
			this.panelAddNew.Location = new System.Drawing.Point(0, 77);
			this.panelAddNew.Name = "panelAddNew";
			this.panelAddNew.Size = new System.Drawing.Size(1130, 144);
			this.panelAddNew.TabIndex = 11;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
			this.btnUpdate.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnUpdate.BorderColor = System.Drawing.Color.Empty;
			this.btnUpdate.BorderThickness = 1.5F;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnUpdate.Location = new System.Drawing.Point(972, 75);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(93, 51);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.SystemColors.Control;
			this.panel9.Controls.Add(this.txtDiaChi);
			this.panel9.Location = new System.Drawing.Point(80, 80);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(850, 40);
			this.panel9.TabIndex = 8;
			this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.BackColor = System.Drawing.SystemColors.Control;
			this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(15, 8);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(800, 22);
			this.txtDiaChi.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tên khách hàng";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.SystemColors.Control;
			this.panel7.Controls.Add(this.txtTenKH);
			this.panel7.Location = new System.Drawing.Point(126, 17);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(379, 40);
			this.panel7.TabIndex = 4;
			this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
			// 
			// txtTenKH
			// 
			this.txtTenKH.BackColor = System.Drawing.SystemColors.Control;
			this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenKH.Location = new System.Drawing.Point(14, 8);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(361, 22);
			this.txtTenKH.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(538, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "SĐT";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Địa chỉ";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.SystemColors.Control;
			this.panel8.Controls.Add(this.txtSDT);
			this.panel8.Location = new System.Drawing.Point(587, 17);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(411, 40);
			this.panel8.TabIndex = 6;
			this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
			// 
			// btnExitPanel
			// 
			this.btnExitPanel.FlatAppearance.BorderSize = 0;
			this.btnExitPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnExitPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnExitPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExitPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitPanel.ForeColor = System.Drawing.Color.Red;
			this.btnExitPanel.Location = new System.Drawing.Point(1090, 10);
			this.btnExitPanel.Name = "btnExitPanel";
			this.btnExitPanel.Size = new System.Drawing.Size(30, 30);
			this.btnExitPanel.TabIndex = 12;
			this.btnExitPanel.Text = "X";
			this.btnExitPanel.UseVisualStyleBackColor = true;
			this.btnExitPanel.Click += new System.EventHandler(this.btnExitPanel_Click);
			// 
			// fKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 869);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "fKhachHang";
			this.Text = "fKhachHang";
			this.Load += new System.EventHandler(this.fKhachHang_Load);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.cmsKhachHang.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelAddNew.ResumeLayout(false);
			this.panelAddNew.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsKhachHang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label lbNext;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPrevious;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Panel panelAddNew;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private CustomDesign.CustomButton btnUpdate;
		private System.Windows.Forms.Button btnExitPanel;
	}
}