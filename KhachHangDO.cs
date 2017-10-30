using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoaLinhAuto_App
{
    public class KhachHangDO
    {
        //constructor
        public KhachHangDO(string makh,string tenkh,string dt1,string dt2,string dt3,string dt4,string diachi1,string diachi2)
        {
            _MaKH = makh;
            _TenKH = tenkh;
            _DT1 = dt1;
            _DT2 = dt2;
            _DT3 = dt3;
            _DT4 = dt4;
            _Diachi1 = diachi1;
            _Diachi2 = diachi2;
        }

        public KhachHangDO()
        { 
            //do nothing
        }

        #region properties
        private string _MaKH;
        private string _TenKH;
        private string _DT1;
        private string _DT2;
        private string _DT3;
        private string _DT4;
        private string _Diachi1;
        private string _Diachi2;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }
        
        public string DT1
        {
            get { return _DT1; }
            set { _DT1 = value; }
        }
        public string DT2
        {
            get { return _DT2; }
            set { _DT2 = value; }
        }
        public string DT3
        {
            get { return _DT3; }
            set { _DT3 = value; }
        }
        public string DT4
        {
            get { return _DT4; }
            set { _DT4 = value; }
        }
        public string Diachi1
        {
            get { return _Diachi1; }
            set { _Diachi1 = value; }
        }
        public string Diachi2
        {
            get { return _Diachi2; }
            set { _Diachi2 = value; }
        }

        #endregion

        

    }
}
