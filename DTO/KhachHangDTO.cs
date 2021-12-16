﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string maKH, tenKH, diaChi, sDT, email;

        public KhachHangDTO()
        {

        }
        public KhachHangDTO(DataRow row)
        {
            this.MaKH = row["Mã khách hàng"].ToString();
            this.TenKH = row["Tên khách hàng"].ToString();
            this.DiaChi = row["Địa chỉ"].ToString();
            this.SDT = row["Số điện thoại"].ToString();
            this.Email = row["Email"].ToString();
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
    }
}
