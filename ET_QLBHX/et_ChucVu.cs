using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBHX
{
    public class et_ChucVu
    {
        private string _MaCV;
        private string _TenChucVu;

        public et_ChucVu(string maCV)
        {
            _MaCV=maCV;
        }

        public et_ChucVu(string maCV, string tenChucVu)
        {
            _MaCV=maCV;
            _TenChucVu=tenChucVu;
        }

        public string MaCV
        {
            get => _MaCV;
            set => _MaCV = value;
        }
        public string TenChucVu
        {
            get => _TenChucVu;
            set => _TenChucVu=value;
        }
    }
}
