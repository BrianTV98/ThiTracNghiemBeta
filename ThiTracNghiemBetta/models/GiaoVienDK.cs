using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.models
{
    class GiaoVienDK: GiaoVien
    {
        private String maMH;
        private String maLop;
        private String trinhDo;
        private String ngayThi;
        private int lan;
        private int soCauThi;
        private int thoiGian;
        public static GiaoVienDK gv_dk;
        public string MaMH { get => maMH; set => maMH = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string NgayThi { get => ngayThi; set => ngayThi = value; }
        public int Lan { get => lan; set => lan = value; }
        public int SoCauThi { get => soCauThi; set => soCauThi = value; }
        public int ThoiGian { get => thoiGian; set => thoiGian = value; }

        public GiaoVienDK(
            String maGV, 
            String maMH, 
            String maLop, 
            String trinhDo, 
            String ngayThi, 
            int lan, int soCauThi, int thoiGian) 
        {
            base.MaGV = maGV;
            this.maMH = maMH;
            this.maLop = maLop;
            this.ngayThi = ngayThi;
            this.trinhDo = trinhDo;
            this.Lan = lan;
            this.SoCauThi = soCauThi;
            this.ThoiGian = thoiGian;
        }
    }
}
