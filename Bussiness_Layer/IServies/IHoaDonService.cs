﻿using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.IServies
{
    public interface IHoaDonService
    {
        public List<HoaDon_Model> GetAll(string? txtTimKiem, string? searchType);
        public Hoadon GetByID(int id);
        public bool Them(Hoadon hoadon);
        public bool Sua(int id, Hoadon hoadon);
        public bool Xoa(int id);
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans();
        public List<Giaychitiet> GetGiaychitiets();
        public List<Hoadonchitiet> GetHoadonchitiets();
        public List<Hoadonchitiet> GetHoadonchitietsById(int hdctId);
        public List<Hoadon> GetHoadons(string search);
        public List<Taikhoan> GetTaikhoans();
        public List<Uudai> GetUudais();
        public List<Khachhang> GetKhachhangs();
        public List<Giay> GetGiays();
        public List<Thuonghieu> GetThuonghieus();
        public List<Mausac> GetMausacs();
        public List<Chatlieu> GetChatlieus();
        public List<Kichco> GetKichcos();
        public List<Kieudang> GetKieudangs();

        public List<HoaDonNhe> hoaDonNhes(string searchText, string searchType);
    }
}
