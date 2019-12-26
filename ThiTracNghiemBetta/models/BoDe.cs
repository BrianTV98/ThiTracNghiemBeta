using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.models
{
    class BoDe
    {
        private int cauHoi;
        private String maMH;
        private String trinhDo;
        private String noiDung;
        private String dapAnA;
        private String dapAnB;
        private String dapAnC;
        private String dapAnD;
        private String dapAnDung;
        private String maGV;

        public int CauHoi { get => cauHoi; set => cauHoi = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string DapAnA { get => dapAnA; set => dapAnA = value; }
        public string DapAnB { get => dapAnB; set => dapAnB = value; }
        public string DapAnC { get => dapAnC; set => dapAnC = value; }
        public string DapAnD { get => dapAnD; set => dapAnD = value; }
        public string DapAnDung { get => dapAnDung; set => dapAnDung = value; }
        public string MaGV { get => maGV; set => maGV = value; }


        public static List<BoDe> boDe;
        public BoDe(int cauHoi, string maMH, string trinhDo, string noiDung, 
            string dapAnA, string dapAnB, string dapAnC, string dapAnD, string dapAnDung, string maGV)
        {
            this.cauHoi = cauHoi;
            this.maMH = maMH;
            this.trinhDo = trinhDo;
            this.noiDung = noiDung;
            this.dapAnA = dapAnA;
            this.dapAnB = dapAnB;
            this.dapAnC = dapAnC;
            this.dapAnD = dapAnD;
            this.dapAnDung = dapAnDung;
            this.maGV = maGV;
        }
    }
}
