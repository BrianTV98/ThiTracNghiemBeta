using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiemBetta.utils
{
    static class utils
    {
        public static String chuanHoaTen(string ten)
        {
            string result = "";
            Int32 count = 10;
            char[] spearator = { ' ' };
            String[] arr = ten.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);
            foreach (string i in arr)
            {
                result = result + i + " ";
            }
            return result.Trim().ToUpper();
        }
    }
}
