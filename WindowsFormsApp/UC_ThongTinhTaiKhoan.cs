﻿using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_ThongTinhTaiKhoan : UserControl
    {

        private string ten;
        public UC_ThongTinhTaiKhoan(string ten)
        {
            InitializeComponent();
            this.ten = ten;
            txtHoVaTen.Text = ten;
            getTT();
        }


        private void getTT()
        {
            DataTable dt = NhanVienBUS.Intance.getTTNV(txtHoVaTen.Text);
            if(dt.Rows.Count > 0)
            {
                txtSĐT.Text = dt.Rows[0]["SDT"].ToString();
                txtChucvu.Text = dt.Rows[0]["Quyen"].ToString();
               // txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                //txtChucvu.Text = dt.Rows[0]["ChucVu"].ToString();
            }
        }

        private void lblDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhauMoi f = new FormDoiMatKhauMoi(txtSĐT.Text);
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }
        string imgLocation = Application.StartupPath + "\\Resources\\hanghoa.png";


        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "PNG files(*.png)|*.png|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlgOpen.FileName.ToString();
                pcbAnh.Image = Image.FromFile(dlgOpen.FileName);
            }
        }
    }
}
