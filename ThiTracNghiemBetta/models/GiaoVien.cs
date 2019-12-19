using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.models
{
    class GiaoVien
    {
        private String maGV;
        private String ho;
        private String ten;
        private String hocVi;
        private String maKh;

        public string MaGV { get => maGV; set => maGV = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string HocVi { get => hocVi; set => hocVi = value; }
        public string MaKh { get => maKh; set => maKh = value; }

        public GiaoVien(string maGV, string ho, string ten, string hocVi, string maKh)
        {
            this.MaGV = maGV;
            this.Ho = ho;
            this.Ten = ten;
            this.HocVi = hocVi;
            this.MaKh = maKh;
        }

        public GiaoVien()
        {
        }

        

    }
}
