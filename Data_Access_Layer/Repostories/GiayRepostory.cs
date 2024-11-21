﻿using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Models.ModelRefer;
using C_Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Data_Access_Layer.Context;

namespace C_Data_Access_Layer.Repostories
{
    public class GiayRepostory :IGiayRepostory
    {
        DuAnBanGiay1Context _db;
        public GiayRepostory()
        {
             _db = new DuAnBanGiay1Context();
        }
        public List<Giay> GetAll(string? txtSearch, string? searchType)
        {
            if (string.Equals(searchType, SearchType.All))
            {
                return _db.Giays.Where(c => c.Magiay.ToString().Contains(txtSearch) || c.Tengiay.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.maGiay))
            {
                return _db.Giays.Where(c => c.Magiay.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.tenGiay))
            {
                return _db.Giays.Where(c => c.Tengiay.Contains(txtSearch)).ToList();
            }
            return _db.Giays.ToList();
        }

        public Giay GetByID(int id)
        {
            return _db.Giays.FirstOrDefault(c => c.Magiay == id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            return false;
        }

        public bool Sua(int id, Giay Giay)
        {
            try
            {
                var Obj = _db.Giays.FirstOrDefault(c => c.Magiay == id);
                if (Obj == null) { return false; }

                Obj.Tengiay = Giay.Tengiay;

                _db.Giays.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Them(Giay Giay)
        {
            try
            {
                _db.Giays.Add(Giay);
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
