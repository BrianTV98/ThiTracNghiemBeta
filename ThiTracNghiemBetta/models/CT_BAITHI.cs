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
            private String dapAnDaChon;
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

            public void ghiBaiThi(int idBangDiem)
            {
                String strlenh = "EXEC SP_GHIBAITHI @ID_BANGDIEM, @CAUHOI, @THUTU, @NOIDUNG, @A, @B, @C, @D, @DAPANDUNG, @DAPANDACHON";
                SqlCommand sqlcommand = new SqlCommand(strlenh, Program.conn);
                sqlcommand.Parameters.AddWithValue("@ID_BANGDIEM", idBangDiem);
                sqlcommand.Parameters.AddWithValue("@CAUHOI", this.cauHoi);
                sqlcommand.Parameters.AddWithValue("@THUTU", this.thuTu);
                sqlcommand.Parameters.AddWithValue("@NOIDUNG", this.noiDung);
                sqlcommand.Parameters.AddWithValue("@A", this.A);
                sqlcommand.Parameters.AddWithValue("@B", this.B);
                sqlcommand.Parameters.AddWithValue("@C", this.C);
                sqlcommand.Parameters.AddWithValue("@D", this.D);
                sqlcommand.Parameters.AddWithValue("@DAPANDUNG", this.dapAnDung);
                sqlcommand.Parameters.AddWithValue("@DAPANDACHON", this.dapAnDaChon);
                SqlDataReader dataReader = null;
                try
                {
                    dataReader = sqlcommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataReader.Close();
            }
        }
    
}
