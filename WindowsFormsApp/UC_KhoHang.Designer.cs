﻿namespace WindowsFormsApp
{
    partial class UC_KhoHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemDVT = new System.Windows.Forms.Button();
            this.btnThemMatHangMoi = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTimKiem.Location = new System.Drawing.Point(768, 20);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(236, 32);
            this.txtTimKiem.TabIndex = 4;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã code",
            "ID",
            "Tên Sản Phẩm",
            "NSX"});
            this.cbbTimKiem.Location = new System.Drawing.Point(648, 19);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(114, 31);
            this.cbbTimKiem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(536, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMatHang);
            this.panel3.Location = new System.Drawing.Point(10, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 585);
            this.panel3.TabIndex = 12;
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AllowUserToAddRows = false;
            this.dgvMatHang.AllowUserToDeleteRows = false;
            this.dgvMatHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Location = new System.Drawing.Point(3, 3);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.ReadOnly = true;
            this.dgvMatHang.RowHeadersVisible = false;
            this.dgvMatHang.RowHeadersWidth = 51;
            this.dgvMatHang.RowTemplate.Height = 24;
            this.dgvMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatHang.Size = new System.Drawing.Size(991, 568);
            this.dgvMatHang.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.cbbTimKiem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThemDVT);
            this.panel2.Controls.Add(this.btnThemMatHangMoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 67);
            this.panel2.TabIndex = 11;
            // 
            // btnThemDVT
            // 
            this.btnThemDVT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDVT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThemDVT.FlatAppearance.BorderSize = 0;
            this.btnThemDVT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDVT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDVT.ForeColor = System.Drawing.Color.White;
            this.btnThemDVT.Location = new System.Drawing.Point(253, 0);
            this.btnThemDVT.Name = "btnThemDVT";
            this.btnThemDVT.Size = new System.Drawing.Size(158, 67);
            this.btnThemDVT.TabIndex = 1;
            this.btnThemDVT.Text = "Thêm ĐVT";
            this.btnThemDVT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDVT.UseVisualStyleBackColor = true;
            this.btnThemDVT.Click += new System.EventHandler(this.btnThemDVT_Click);
            // 
            // btnThemMatHangMoi
            // 
            this.btnThemMatHangMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMatHangMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThemMatHangMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMatHangMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMatHangMoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMatHangMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMatHangMoi.Location = new System.Drawing.Point(0, 0);
            this.btnThemMatHangMoi.Name = "btnThemMatHangMoi";
            this.btnThemMatHangMoi.Size = new System.Drawing.Size(253, 67);
            this.btnThemMatHangMoi.TabIndex = 0;
            this.btnThemMatHangMoi.Text = "Thêm Mặt Hàng Mới";
            this.btnThemMatHangMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMatHangMoi.UseVisualStyleBackColor = true;
            this.btnThemMatHangMoi.Click += new System.EventHandler(this.btnThemMatHangMoi_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 10);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // UC_KhoHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UC_KhoHang";
            this.Size = new System.Drawing.Size(1010, 662);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.Button btnThemDVT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemMatHangMoi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
