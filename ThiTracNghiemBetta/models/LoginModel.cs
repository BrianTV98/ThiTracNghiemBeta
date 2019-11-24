using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.models
{
    enum UserType
    {
        GiangVien = 0,
        SinhVien = 1,
        None = 2
    }
    class LoginModel
    {
        public String userName;
        public String password;
        public String serverName;

        public UserType userType;

        public bool isValid()
        {
            bool result = true;
            if (userName.Length == 0 || password.Length == 0 || serverName.Length == 0 || userType == UserType.None)
            {
                result = false;
            }
            return result;
            
        }
    }

}
