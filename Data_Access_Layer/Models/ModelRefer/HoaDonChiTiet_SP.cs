﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Data_Access_Layer.Models.ModelRefer
{
    public class HoaDonChiTiet_SP
    {
        public Hoadonchitiet Hoadonchitiet { get; set; }
        public string? tenGiay { get; set; }
        public string? tenThuongHieu { get; set; }
        public string? tenKieuDang { get; set; }
        public string? tenKichCo { get; set; }
        public string? tenMauSac { get; set; }
        public string? tenChatLieu { get; set; }
    }
}
