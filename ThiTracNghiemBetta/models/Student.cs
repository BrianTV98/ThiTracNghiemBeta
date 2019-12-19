using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.models
{
    class Student
    {
        private String maSV;
        private String ho;
        private String ten;
        private DateTime ngaySinh;
        private String diaChi;
        private String maLop;

        public string MaSV { get => maSV; set => maSV = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaLop { get => maLop; set => maLop = value; }

        public Student(string maSV, string ho, string ten, DateTime ngaySinh, string diaChi, string maLop)
        {
            this.maSV = maSV;
            this.ho = ho;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.maLop = maLop;
        }
        public Student()
        {
        }
    }
}
