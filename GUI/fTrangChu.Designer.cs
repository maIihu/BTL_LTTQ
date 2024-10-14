namespace GUI
{
    partial class fTrangChu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPanel = new System.Windows.Forms.Panel();
            this.btnMoreYeuCau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTrangChu = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.lbTongYeuCau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.lbTongHoaDon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BieuDoDoanhThu = new LiveCharts.WinForms.CartesianChart();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BieuDoTongKet = new LiveCharts.WinForms.CartesianChart();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangChu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPanel
            // 
            this.dgvPanel.BackColor = System.Drawing.SystemColors.Window;
            this.dgvPanel.Controls.Add(this.btnMoreYeuCau);
            this.dgvPanel.Controls.Add(this.label1);
            this.dgvPanel.Controls.Add(this.dgvTrangChu);
            this.dgvPanel.Location = new System.Drawing.Point(30, 140);
            this.dgvPanel.Name = "dgvPanel";
            this.dgvPanel.Size = new System.Drawing.Size(742, 720);
            this.dgvPanel.TabIndex = 6;
            this.dgvPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvPanel_Paint);
            // 
            // btnMoreYeuCau
            // 
            this.btnMoreYeuCau.BackgroundImage = global::GUI.Properties.Resources.bacham;
            this.btnMoreYeuCau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMoreYeuCau.FlatAppearance.BorderSize = 0;
            this.btnMoreYeuCau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMoreYeuCau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMoreYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreYeuCau.Location = new System.Drawing.Point(690, 20);
            this.btnMoreYeuCau.Name = "btnMoreYeuCau";
            this.btnMoreYeuCau.Size = new System.Drawing.Size(20, 20);
            this.btnMoreYeuCau.TabIndex = 3;
            this.btnMoreYeuCau.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yêu cầu gần đây";
            // 
            // dgvTrangChu
            // 
            this.dgvTrangChu.AllowUserToAddRows = false;
            this.dgvTrangChu.AllowUserToDeleteRows = false;
            this.dgvTrangChu.AllowUserToResizeColumns = false;
            this.dgvTrangChu.AllowUserToResizeRows = false;
            this.dgvTrangChu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTrangChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrangChu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvTrangChu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrangChu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTrangChu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrangChu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.TenKhachHang,
            this.NguyenNhan,
            this.NgaySua});
            this.dgvTrangChu.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTrangChu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvTrangChu.Location = new System.Drawing.Point(16, 50);
            this.dgvTrangChu.MultiSelect = false;
            this.dgvTrangChu.Name = "dgvTrangChu";
            this.dgvTrangChu.ReadOnly = true;
            this.dgvTrangChu.RowHeadersVisible = false;
            this.dgvTrangChu.RowHeadersWidth = 51;
            this.dgvTrangChu.RowTemplate.Height = 30;
            this.dgvTrangChu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTrangChu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTrangChu.Size = new System.Drawing.Size(710, 655);
            this.dgvTrangChu.TabIndex = 0;
            this.dgvTrangChu.TabStop = false;
            this.dgvTrangChu.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTrangChu_CellPainting);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 125;
            // 
            // NguyenNhan
            // 
            this.NguyenNhan.HeaderText = "Nguyên nhân";
            this.NguyenNhan.MinimumWidth = 6;
            this.NguyenNhan.Name = "NguyenNhan";
            this.NguyenNhan.ReadOnly = true;
            this.NguyenNhan.Width = 125;
            // 
            // NgaySua
            // 
            this.NgaySua.HeaderText = "Ngày sửa";
            this.NgaySua.MinimumWidth = 6;
            this.NgaySua.Name = "NgaySua";
            this.NgaySua.ReadOnly = true;
            this.NgaySua.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(30, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 120);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::GUI.Properties.Resources.Group_1000000839;
            this.pictureBox13.Location = new System.Drawing.Point(271, 23);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(44, 20);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 10;
            this.pictureBox13.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "£8,245.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Net Income";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::GUI.Properties.Resources.bacham;
            this.pictureBox10.Location = new System.Drawing.Point(321, 23);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 21);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GUI.Properties.Resources.dollar_circle;
            this.pictureBox5.Location = new System.Drawing.Point(23, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.dothi;
            this.pictureBox2.Location = new System.Drawing.Point(243, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Controls.Add(this.lbTongYeuCau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(412, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 120);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::GUI.Properties.Resources.Group_1000000839;
            this.pictureBox14.Location = new System.Drawing.Point(269, 23);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(44, 20);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 11;
            this.pictureBox14.TabStop = false;
            // 
            // lbTongYeuCau
            // 
            this.lbTongYeuCau.AutoSize = true;
            this.lbTongYeuCau.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongYeuCau.Location = new System.Drawing.Point(70, 55);
            this.lbTongYeuCau.Name = "lbTongYeuCau";
            this.lbTongYeuCau.Size = new System.Drawing.Size(122, 37);
            this.lbTongYeuCau.TabIndex = 9;
            this.lbTongYeuCau.Text = "256 đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng hóa đơn";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::GUI.Properties.Resources.bacham;
            this.pictureBox11.Location = new System.Drawing.Point(319, 23);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 21);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 4;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GUI.Properties.Resources.cart_02;
            this.pictureBox6.Location = new System.Drawing.Point(23, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.dothi;
            this.pictureBox3.Location = new System.Drawing.Point(241, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.pictureBox15);
            this.panel3.Controls.Add(this.lbTongHoaDon);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(794, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 120);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::GUI.Properties.Resources.Group_1000000839;
            this.pictureBox15.Location = new System.Drawing.Point(271, 23);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(44, 20);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox15.TabIndex = 12;
            this.pictureBox15.TabStop = false;
            // 
            // lbTongHoaDon
            // 
            this.lbTongHoaDon.AutoSize = true;
            this.lbTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongHoaDon.Location = new System.Drawing.Point(70, 55);
            this.lbTongHoaDon.Name = "lbTongHoaDon";
            this.lbTongHoaDon.Size = new System.Drawing.Size(145, 37);
            this.lbTongHoaDon.TabIndex = 10;
            this.lbTongHoaDon.Text = "1,256 đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đã sửa chữa";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::GUI.Properties.Resources.bacham;
            this.pictureBox12.Location = new System.Drawing.Point(321, 23);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 21);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 5;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GUI.Properties.Resources.tag_01;
            this.pictureBox7.Location = new System.Drawing.Point(25, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.dothi;
            this.pictureBox4.Location = new System.Drawing.Point(243, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.BieuDoDoanhThu);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(794, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 400);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // BieuDoDoanhThu
            // 
            this.BieuDoDoanhThu.Location = new System.Drawing.Point(15, 42);
            this.BieuDoDoanhThu.Name = "BieuDoDoanhThu";
            this.BieuDoDoanhThu.Size = new System.Drawing.Size(330, 350);
            this.BieuDoDoanhThu.TabIndex = 14;
            this.BieuDoDoanhThu.Text = "cartesianChart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Báo cáo doanh thu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.BieuDoTongKet);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(794, 556);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 300);
            this.panel5.TabIndex = 11;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // BieuDoTongKet
            // 
            this.BieuDoTongKet.Location = new System.Drawing.Point(20, 39);
            this.BieuDoTongKet.Name = "BieuDoTongKet";
            this.BieuDoTongKet.Size = new System.Drawing.Size(320, 240);
            this.BieuDoTongKet.TabIndex = 15;
            this.BieuDoTongKet.Text = "cartesianChart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tổng kết tuần";
            // 
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 869);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fTrangChu";
            this.Text = "fTrangChu";
            this.Load += new System.EventHandler(this.fTrangChu_Load);
            this.dgvPanel.ResumeLayout(false);
            this.dgvPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangChu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel dgvPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbTongYeuCau;
		private System.Windows.Forms.Label lbTongHoaDon;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvTrangChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySua;
        private System.Windows.Forms.Button btnMoreYeuCau;
        private LiveCharts.WinForms.CartesianChart BieuDoDoanhThu;
        private LiveCharts.WinForms.CartesianChart BieuDoTongKet;
    }
}