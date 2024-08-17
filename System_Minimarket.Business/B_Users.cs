using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Minimarket.Data;
using System_Minimarket.Entities;

namespace System_Minimarket.Business
{
    public class B_Users
    {
        public static DataTable Listing_us(string cText)
        {
            D_Users Data = new D_Users();
            return Data.Listing_us(cText);
        }

        public static string Save_us(int nOption, E_Users oUs)
        {
            D_Users Data = new D_Users();
            return Data.Save_us(nOption, oUs);
        }

        public static string Delete_us(int Id_us)
        {
            D_Users Data = new D_Users();
            return Data.Delete_us(Id_us);
        }

        public static DataTable Login_us(string cLogin, string cPassword)
        {
            D_Users Data = new D_Users();
            return Data.Login_us(cLogin, cPassword);
        }
    }
}
