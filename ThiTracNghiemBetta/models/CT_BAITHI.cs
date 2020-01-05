using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemBetta.models
{
    class CT_BaiThi
    {
        
            private int idCTBaiThi;
            private int idBangDiem;
            private int cauHoi;
            private int thuTu;
            private String noiDung;
            private String A;
            private String B;
            private String C;
            private String D;
            private String dapAnDung;
            private String dapAnDaChon = "";
        public static ArrayList thithu = new ArrayList();
        public static ArrayList ct_baiThi = new ArrayList();
            public CT_BaiThi(int idCTBaiThi, int idBangDiem, int cauHoi, int thuTu, String noiDung, String A, String B, String C, String D, String dapAnDung, String dapAnDaChon)
            {
                this.idCTBaiThi = idCTBaiThi;
                this.idBangDiem = idBangDiem;
                this.cauHoi = cauHoi;
                this.thuTu = thuTu;
                this.noiDung = noiDung;
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
                this.dapAnDung = dapAnDung;
                this.dapAnDaChon = dapAnDaChon;
            }

            public CT_BaiThi(int idBangDiem, int cauHoi, int thuTu, String noiDung, String A, String B, String C, String D, String dapAnDung, String dapAnDaChon)
            {
                this.idBangDiem = idBangDiem;
                this.cauHoi = cauHoi;
                this.thuTu = thuTu;
                this.noiDung = noiDung;
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
                this.dapAnDung = dapAnDung;
                this.dapAnDaChon = dapAnDaChon;
            }

            public int getIdCTBaiThi()
            {
                return idCTBaiThi;
            }

            public int getIdBangDiem()
            {
                return idBangDiem;
            }

            public int getCauHoi()
            {
                return cauHoi;
            }

            public int getThuTu()
            {
                return thuTu;
            }

            public String getNoiDung()
            {
                return noiDung;
            }

            public String getA()
            {
                return A;
            }

            public String getB()
            {
                return B;
            }

            public String getC()
            {
                return C;
            }

            public String getD()
            {
                return D;
            }

            public String getDapAnDung()
            {
                return dapAnDung;
            }

            public String getDapAnDaChon()
            {
                return dapAnDaChon;
            }
            public CT_BaiThi(int cauHoi, int thuTu, String noiDung, String A, String B, String C, String D, String dapAnDung, String dapAnDaChon)
            {
                this.cauHoi = cauHoi;
                this.thuTu = thuTu;
                this.noiDung = noiDung;
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
                this.dapAnDung = dapAnDung;
                this.dapAnDaChon = dapAnDaChon;
            }

            public void setIdBangDiem(int idBangDiem)
            {
                this.idBangDiem = idBangDiem;
            }
            public void setDapDaChon(String dapAn)
            {
                this.dapAnDaChon = dapAn;
            }
        }
    
}
