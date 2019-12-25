using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.models
{
    class BangDiem
    {
        private String maSV;
        private String maMH;
        private int lan;
        private String ngayThi;
        private float diem;
        private int idBangDiem;

        public BangDiem(String maSV, String maMH, int lan, String ngayThi, float diem)
        {
            this.maSV = maSV;
            this.maMH = maMH;
            this.lan = lan;
            this.ngayThi = ngayThi;
            this.diem = diem;
        }

        public BangDiem(String maSV, String maMH, int lan, String ngayThi, float diem, int idBangDiem)
        {
            this.maSV = maSV;
            this.maMH = maMH;
            this.lan = lan;
            this.ngayThi = ngayThi;
            this.diem = diem;
            this.idBangDiem = idBangDiem;
        }


        public String getMaSV()
        {
            return maSV;
        }

        public String getMaMH()
        {
            return maMH;
        }

        public int getLan()
        {
            return lan;
        }

        public String getNgayThi()
        {
            return ngayThi;
        }

        public float getDiem()
        {
            return diem;
        }

        public int getIdBangDiem()
        {
            return idBangDiem;
        }
        public void ghiDiem()
        {
            String strlenh = "EXEC SP_GHIBANGDIEM '" + this.maSV + "', '" + this.maMH + "', " + this.lan + ","
                + "'" + this.ngayThi + "', " + this.diem;
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            Program.myReader.Close();
        }
    }
}
