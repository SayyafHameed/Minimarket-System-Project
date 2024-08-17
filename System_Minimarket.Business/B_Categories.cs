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
    public class B_Categories
    {
        public static DataTable Listing_ca(string cText)
        {
            D_Categories categories = new D_Categories();
            return categories.Listing_ca(cText);
        }

        public static string Save_ca(int nOption, E_Categories oCa)
        {
            D_Categories Data = new D_Categories();
            return Data.Save_ca(nOption, oCa);
        }

        public static string Delete_ca(int Id_ca)
        {
            D_Categories Data = new D_Categories();
            return Data.Delete_ca(Id_ca);
        }
    }
}
