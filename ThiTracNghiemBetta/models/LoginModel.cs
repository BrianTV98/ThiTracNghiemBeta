using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.models
{
    class LoginModel
    {

        public String userName;
        public String password;

        public bool isValid()
        {
            bool result = true;
            if (userName.Length == 0 || password.Length == 0)
            {
                result = false;
            }
            return result;
            
        }
    }

}
