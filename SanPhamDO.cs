using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoaLinhAuto_App
{
    public class SanPhamDO
    {
        public SanPhamDO()
        {
        }

        public SanPhamDO(string masp, string tensp, string chitiet, int soluong, int giavon, int giaban)
        {
            _MaSP = masp;
            _TenSP = tensp;
            _ChiTiet = chitiet;
            _SoLuong = soluong;
            _GiaVon = giavon;
            _GiaBan = giaban;
        }

        private string _MaSP;
        private string _TenSP;
        private string _ChiTiet;
        private int _SoLuong;
        private int _GiaVon;
        private int _GiaBan;

        public int GiaBan
        {
            get { return _GiaBan; }
            set { _GiaBan = value; }
        }

        public int GiaVon
        {
            get { return _GiaVon; }
            set { _GiaVon = value; }
        }

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public string ChiTiet
        {
            get { return _ChiTiet; }
            set { _ChiTiet = value; }
        }

        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        public string MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }
    }
}
