﻿using B_Bussiness_Layer.IServies;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using C_Data_Access_Layer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.Services
{
    public class HoaDonService : IHoaDonService
    {
        HoaDonRepository _Rep;
        public HoaDonService()
        {
            _Rep = new HoaDonRepository();
        }
        public List<HoaDon_Model> GetAll(string? txtTimKiem, string? searchType)
        {
            return _Rep.GetAll(txtTimKiem, searchType);
        }
        public List<Giaychitiet> GetGiaychitiets()
        {
            return _Rep.GetGiaychitiets();
        }
        public Hoadon GetByID(int id)
        {
            return _Rep.GetByID(id);
        }
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans()
        {
            return _Rep.GetHinhthucthanhtoans();
        }

        public bool Sua(int id, Hoadon hoadon)
        {
            return _Rep.Sua(id, hoadon);
        }

        public bool Them(Hoadon hoadon)
        {
            return _Rep.Them(hoadon);
        }

        public bool Xoa(int id)
        {
            return _Rep.Xoa(id);
        }
        public List<Hoadonchitiet> GetHoadonchitiets()
        {
            return _Rep.GetHoadonchitiets();
        }
        public List<Hoadonchitiet> GetHoadonchitietsById(int hdctId)
        {
            return _Rep.GetHoadonchitietsById(hdctId);
        }
        public List<HoaDonNhe> hoaDonNhes(string searchText, string searchType)
        {
            return _Rep.hoaDonNhes(searchText, searchType);
        }
        public List<Giay> GetGiays()
        {
            return _Rep.GetGiays();
        }
        public List<Thuonghieu> GetThuonghieus()
        {
            return _Rep.GetThuonghieus();
        }
        public List<Chatlieu> GetChatlieus()
        {
            return _Rep.GetChatlieus();
        }
        public List<Mausac> GetMausacs()
        {
            return _Rep.GetMausacs();
        }
        public List<Kichco> GetKichcos()
        {
            return _Rep.GetKichcos();
        }
        public List<Kieudang> GetKieudangs()
        {
            return _Rep.GetKieudangs();
        }
        public List<Hoadon> GetHoadons(string search)
        {
            return _Rep.GetHoadons(search);
        }

        public List<Khachhang> GetKhachhangs()
        {
            return _Rep.GetKhachhangs();
        }

        public List<Taikhoan> GetTaikhoans()
        {
            return _Rep.GetTaikhoans();
        }

        public List<Uudai> GetUudais()
        {
            return _Rep.GetUudais();
        }

    }
}
