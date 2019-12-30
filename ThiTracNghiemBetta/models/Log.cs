using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.models
{
     public class DataLogGVDK
    {
        string action;
        GiaoVienDK truoc;
        GiaoVienDK sau;

        public DataLogGVDK()
        {
        }
        public DataLogGVDK(string action, GiaoVienDK truoc, GiaoVienDK sau)
        {
            this.Action = action;
            this.Truoc = truoc;
            this.Sau = sau;
        }

        public string Action { get => action; set => action = value; }
        public GiaoVienDK Truoc { get => truoc; set => truoc = value; }
        public GiaoVienDK Sau { get => sau; set => sau = value; }
    }
}
