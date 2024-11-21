﻿using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.Services
{
    public class KieuDangService
    {
        KieuDangRepostory _Rep;
        public KieuDangService()
        {
            _Rep = new KieuDangRepostory(); 
        }
        public List<Kieudang> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }

        public Kieudang GetByID(int id)
        {
            return _Rep.GetByID(id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            if (id == 0 || id == null)
            {
                return false;
            }

            return _Rep.Khoa_MoKhoa(id);
        }

        public bool Sua(int id, Kieudang Kieudang)
        {
            if (id == 0 || id == null)
            {
                return false;
            }
            else if (Kieudang == null)
            {
                return false;
            }

            else if (Kieudang.Tenkieudang == "" || Kieudang.Mota == "")
            {
                return false;
            }
            return _Rep.Sua(id, Kieudang);
        }

        public bool Them(Kieudang Kieudang)
        {
            if (Kieudang == null)
            {
                return false;
            }
            else if (Kieudang.Tenkieudang == "" || Kieudang.Mota == "")
            {
                return false;
            }

            else if (Kieudang.Mataikhoan == 0 || Kieudang.Mataikhoan == null)
            {
                return false;
            }

            return _Rep.Them(Kieudang);
        }

    }
}
