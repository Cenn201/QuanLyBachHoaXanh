using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBHX
{
    public class et_BoPhan
    {
        private string _MaBP;
        private string _TenBP;

        public et_BoPhan(string maBP, string tenBP)
        {
            _MaBP=maBP;
            _TenBP=tenBP;
        }

        public string MaBP
        {
            get => _MaBP;
            set => _MaBP=value;
        }
        public string TenBP
        {
            get => _TenBP;
            set => _TenBP=value;
        }
    }
}
