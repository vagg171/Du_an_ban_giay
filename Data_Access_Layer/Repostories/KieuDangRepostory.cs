﻿using C_Data_Access_Layer.Models.ModelRefer;
using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Context;

namespace C_Data_Access_Layer.Repostories
{
    public class KieuDangRepostory:IKieuDangRepostory
    {
        DuAnBanGiay1Context _db;
        public KieuDangRepostory()
        {
            _db = new DuAnBanGiay1Context();
        }
        public List<Kieudang> GetAll(string? txtSearch, string? searchType)
        {
            if (string.Equals(searchType, SearchType.All))
            {
                return _db.Kieudangs.Where(c => c.Mataikhoan.ToString().Contains(txtSearch) || c.Trangthai.ToString().Contains(txtSearch) || c.Tenkieudang.Contains(txtSearch) || c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.tenKieuDang))
            {
                return _db.Kieudangs.Where(c => c.Tenkieudang.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.moTaKieuDang))
            {
                return _db.Kieudangs.Where(c => c.Mota.Contains(txtSearch)).ToList();
            }

            return _db.Kieudangs.ToList();
        }

        public Kieudang GetByID(int id)
        {
            return _db.Kieudangs.FirstOrDefault(c => c.Makieudang == id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            try
            {
                var Obj = _db.Kieudangs.FirstOrDefault(c => c.Makieudang == id);
                if (Obj == null) { return false; }
                if (Obj.Trangthai == true)
                {
                    Obj.Trangthai = false;
                }
                else
                {
                    Obj.Trangthai = true;
                }
                _db.Kieudangs.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Sua(int id, Kieudang Kieudang)
        {
            try
            {
                var Obj = _db.Kieudangs.FirstOrDefault(c => c.Makieudang == id);
                if (Obj == null) { return false; }

                Obj.Tenkieudang = Kieudang.Tenkieudang;
                Obj.Mota = Kieudang.Mota;

                _db.Kieudangs.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Them(Kieudang Kieudang)
        {
            try
            {
                _db.Kieudangs.Add(Kieudang);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Inner Exception: " + e.InnerException.Message);
                return false;
            }
        }
    }
}
