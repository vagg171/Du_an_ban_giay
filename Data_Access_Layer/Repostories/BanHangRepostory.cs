﻿using C_Data_Access_Layer.Context;
using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Repostories
{
    public class BanHangRepostory: IBanHangRepostory
    {
        DuAnBanGiay1Context dbContext;
        public BanHangRepostory()
        {
            dbContext = new DuAnBanGiay1Context();
        }

        public bool AddHD(Hoadon hoadon)
        {
            throw new NotImplementedException();
        }

        public List<Chatlieu> GetChatlieu()
        {
            return dbContext.Chatlieus.ToList();
        }

        public List<Giaychitiet> GetGiaychitiets()
        {
            return dbContext.Giaychitiets.ToList();
        }

        public List<Giay> GetGiays()
        {
            return dbContext.Giays.ToList();
        }

        public List<Hoadonchitiet> GetHoadonchitiets()
        {
            return dbContext.Hoadonchitiets.ToList();
        }

        public List<Hoadon> GetHoadons()
        {
            return dbContext.Hoadons.ToList();
        }

        public List<Khachhang> GetKhachhang()
        {
            return dbContext.Khachhangs.ToList();
        }

        public List<Kichco> GetKichcos()
        {
            return dbContext.Kichcos.ToList();
        }

        public List<Kieudang> GetKieudangs()
        {
            return dbContext.Kieudangs.ToList();
        }

        public List<Mausac> GetMausacs()
        {
            return dbContext.Mausacs.ToList();
        }

        public List<Taikhoan> GetTaikhoan()
        {
            return dbContext.Taikhoans.ToList();
        }

        public List<Thuonghieu> GetThuonghieu()
        {
            return dbContext.Thuonghieus.ToList();
        }

        public bool HuyHD(Hoadon hoadon)
        {
            throw new NotImplementedException();
        }

        public bool UpdateHD(Hoadon hoadon)
        {
            throw new NotImplementedException();
        }
    }
}
