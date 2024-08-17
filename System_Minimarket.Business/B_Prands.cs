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
    public class B_Prands
    {
        public static DataTable Listing_pr(string cText)
        {
            D_Prands Data = new D_Prands();
            return Data.Listing_pr(cText);
        }

        public static string Save_pr(int nOption, E_Prands oPr)
        {
            D_Prands Data = new D_Prands();
            return Data.Save_pr(nOption, oPr);
        }

        public static string Delete_pr(int Id_pr)
        {
            D_Prands Data = new D_Prands();
            return Data.Delete_pr(Id_pr);
        }
    }
}
