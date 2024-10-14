namespace GUI
{
    partial class fCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dsKhachHang = new System.Windows.Forms.DataGridView();
            this.ColMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(869, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsKhachHang
            // 
            this.dsKhachHang.AllowUserToAddRows = false;
            this.dsKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dsKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dsKhachHang.ColumnHeadersHeight = 50;
            this.dsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dsKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaKhachHang,
            this.ColTenKhachHang,
            this.ColDiaChi,
            this.ColSdt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dsKhachHang.EnableHeadersVisualStyles = false;
            this.dsKhachHang.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dsKhachHang.Location = new System.Drawing.Point(19, 65);
            this.dsKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dsKhachHang.Name = "dsKhachHang";
            this.dsKhachHang.RowHeadersVisible = false;
            this.dsKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dsKhachHang.RowTemplate.DividerHeight = 2;
            this.dsKhachHang.RowTemplate.Height = 40;
            this.dsKhachHang.RowTemplate.ReadOnly = true;
            this.dsKhachHang.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dsKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsKhachHang.Size = new System.Drawing.Size(990, 533);
            this.dsKhachHang.TabIndex = 5;
            this.dsKhachHang.TabStop = false;
            this.dsKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsKhachHang_CellContentClick);
            this.dsKhachHang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dsKhachHang.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // ColMaKhachHang
            // 
            this.ColMaKhachHang.DataPropertyName = "MaKhachHang";
            this.ColMaKhachHang.HeaderText = "CustomerID";
            this.ColMaKhachHang.MinimumWidth = 6;
            this.ColMaKhachHang.Name = "ColMaKhachHang";
            this.ColMaKhachHang.ReadOnly = true;
            // 
            // ColTenKhachHang
            // 
            this.ColTenKhachHang.DataPropertyName = "TenKhachHang";
            this.ColTenKhachHang.FillWeight = 160F;
            this.ColTenKhachHang.HeaderText = "Full Name";
            this.ColTenKhachHang.MinimumWidth = 6;
            this.ColTenKhachHang.Name = "ColTenKhachHang";
            this.ColTenKhachHang.ReadOnly = true;
            // 
            // ColDiaChi
            // 
            this.ColDiaChi.DataPropertyName = "DiaChi";
            this.ColDiaChi.FillWeight = 240F;
            this.ColDiaChi.HeaderText = "Address";
            this.ColDiaChi.MinimumWidth = 6;
            this.ColDiaChi.Name = "ColDiaChi";
            this.ColDiaChi.ReadOnly = true;
            // 
            // ColSdt
            // 
            this.ColSdt.DataPropertyName = "SoDienThoai";
            this.ColSdt.FillWeight = 140F;
            this.ColSdt.HeaderText = "Phone";
            this.ColSdt.MinimumWidth = 6;
            this.ColSdt.Name = "ColSdt";
            this.ColSdt.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(6, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btnFix.FlatAppearance.BorderSize = 0;
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFix.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.Color.White;
            this.btnFix.Location = new System.Drawing.Point(116, 4);
            this.btnFix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(105, 32);
            this.btnFix.TabIndex = 10;
            this.btnFix.Text = "Update";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnFix);
            this.panel2.Location = new System.Drawing.Point(772, 609);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 41);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::GUI.Properties.Resources.SearchBar;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.txtTim);
            this.panel3.Location = new System.Drawing.Point(22, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 32);
            this.panel3.TabIndex = 13;
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.White;
            this.txtTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(38, 9);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(255, 16);
            this.txtTim.TabIndex = 7;
            this.txtTim.Text = "Search...";
            this.txtTim.WordWrap = false;
            this.txtTim.Click += new System.EventHandler(this.txtTim_Click);
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            this.txtTim.Leave += new System.EventHandler(this.txtTim_Leave);
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1028, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dsKhachHang);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dsKhachHang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSdt;
    }
}