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
    public class B_Items
    {
        public static DataTable Listing_it(string cText)
        {
            D_Items Data = new D_Items();
            return Data.Listing_it(cText);
        }

        public static string Save_it(int nOption, E_Items oPr)
        {
            D_Items Data = new D_Items();
            return Data.Save_it(nOption, oPr);
        }

        public static string Delete_it(int Id_pr)
        {
            D_Items Data = new D_Items();
            return Data.Delete_it(Id_pr);
        }
    }
}
