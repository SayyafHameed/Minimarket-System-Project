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
    public class B_Stores
    {
        public static DataTable Listing_st(string cText)
        {
            D_Stores Data = new D_Stores();
            return Data.Listing_st(cText);
        }

        public static string Save_st(int nOption, E_Stores oPr)
        {
            D_Stores Data = new D_Stores();
            return Data.Save_st(nOption, oPr);
        }

        public static string Delete_st(int Id_pr)
        {
            D_Stores Data = new D_Stores();
            return Data.Delete_st(Id_pr);
        }
    }
}
