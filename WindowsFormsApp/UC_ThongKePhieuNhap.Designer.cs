﻿
namespace WindowsFormsApp
{
    partial class UC_ThongKePhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemchitiet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvPN = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.pcbSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTk = new System.Windows.Forms.Label();
            this.txtmapn = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearch)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemchitiet);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Controls.Add(this.pcbSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtmapn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 834);
            this.panel1.TabIndex = 0;
            // 
            // btnXemchitiet
            // 
            this.btnXemchitiet.Animated = true;
            this.btnXemchitiet.AutoRoundedCorners = true;
            this.btnXemchitiet.BackColor = System.Drawing.Color.Transparent;
            this.btnXemchitiet.BorderRadius = 26;
            this.btnXemchitiet.CheckedState.Parent = this.btnXemchitiet;
            this.btnXemchitiet.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXemchitiet.CustomImages.Parent = this.btnXemchitiet;
            this.btnXemchitiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemchitiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemchitiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemchitiet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemchitiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemchitiet.DisabledState.Parent = this.btnXemchitiet;
            this.btnXemchitiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnXemchitiet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnXemchitiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXemchitiet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXemchitiet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(1)))), ((int)(((byte)(139)))));
            this.btnXemchitiet.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnXemchitiet.HoverState.Parent = this.btnXemchitiet;
            this.btnXemchitiet.Location = new System.Drawing.Point(1028, 56);
            this.btnXemchitiet.Name = "btnXemchitiet";
            this.btnXemchitiet.ShadowDecoration.Parent = this.btnXemchitiet;
            this.btnXemchitiet.Size = new System.Drawing.Size(184, 55);
            this.btnXemchitiet.TabIndex = 359;
            this.btnXemchitiet.Text = "Xem chi tiết";
            this.btnXemchitiet.UseTransparentBackground = true;
            this.btnXemchitiet.Click += new System.EventHandler(this.btnXemchitiet_Click_1);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvPN);
            this.panel5.Location = new System.Drawing.Point(21, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1191, 694);
            this.panel5.TabIndex = 240;
            // 
            // dgvPN
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPN.BackgroundColor = System.Drawing.Color.White;
            this.dgvPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPN.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPN.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPN.EnableHeadersVisualStyles = false;
            this.dgvPN.GridColor = System.Drawing.Color.Black;
            this.dgvPN.Location = new System.Drawing.Point(-1, 3);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPN.RowHeadersVisible = false;
            this.dgvPN.RowHeadersWidth = 62;
            this.dgvPN.RowTemplate.Height = 45;
            this.dgvPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPN.Size = new System.Drawing.Size(1191, 654);
            this.dgvPN.TabIndex = 228;
            this.dgvPN.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPN.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPN.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPN.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPN.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPN.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPN.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvPN.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.dgvPN.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPN.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPN.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPN.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPN.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvPN.ThemeStyle.ReadOnly = true;
            this.dgvPN.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPN.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPN.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPN.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPN.ThemeStyle.RowsStyle.Height = 45;
            this.dgvPN.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPN.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellContentClick_1);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimkiem.BorderThickness = 0;
            this.txtTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiem.DefaultText = "";
            this.txtTimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.DisabledState.Parent = this.txtTimkiem;
            this.txtTimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimkiem.FocusedState.Parent = this.txtTimkiem;
            this.txtTimkiem.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.HoverState.Parent = this.txtTimkiem;
            this.txtTimkiem.Location = new System.Drawing.Point(126, 61);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.ShadowDecoration.Parent = this.txtTimkiem;
            this.txtTimkiem.Size = new System.Drawing.Size(296, 43);
            this.txtTimkiem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTimkiem.TabIndex = 200;
            // 
            // pcbSearch
            // 
            this.pcbSearch.BackColor = System.Drawing.Color.White;
            this.pcbSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pcbSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.pcbSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.pcbSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbSearch.IconSize = 34;
            this.pcbSearch.Location = new System.Drawing.Point(418, 70);
            this.pcbSearch.Name = "pcbSearch";
            this.pcbSearch.Size = new System.Drawing.Size(36, 34);
            this.pcbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSearch.TabIndex = 199;
            this.pcbSearch.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 198;
            this.label2.Text = "Tìm kiếm:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 50);
            this.panel2.TabIndex = 189;
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.Location = new System.Drawing.Point(15, 12);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(206, 32);
            this.lblTk.TabIndex = 14;
            this.lblTk.Text = "Thống kê phiếu nhập";
            // 
            // txtmapn
            // 
            this.txtmapn.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtmapn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmapn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmapn.DefaultText = "";
            this.txtmapn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmapn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmapn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmapn.DisabledState.Parent = this.txtmapn;
            this.txtmapn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmapn.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtmapn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmapn.FocusedState.Parent = this.txtmapn;
            this.txtmapn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapn.ForeColor = System.Drawing.Color.Black;
            this.txtmapn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmapn.HoverState.Parent = this.txtmapn;
            this.txtmapn.Location = new System.Drawing.Point(225, 1344);
            this.txtmapn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.PasswordChar = '\0';
            this.txtmapn.PlaceholderText = "";
            this.txtmapn.SelectedText = "";
            this.txtmapn.ShadowDecoration.Parent = this.txtmapn;
            this.txtmapn.Size = new System.Drawing.Size(118, 41);
            this.txtmapn.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtmapn.TabIndex = 45;
            // 
            // UC_ThongKePhieuNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongKePhieuNhap";
            this.Size = new System.Drawing.Size(1234, 834);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtmapn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTk;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private FontAwesome.Sharp.IconPictureBox pcbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPN;
        private Guna.UI2.WinForms.Guna2GradientButton btnXemchitiet;
    }
}
