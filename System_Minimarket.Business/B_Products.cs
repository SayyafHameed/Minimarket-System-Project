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
    public class B_Products
    {
        public static DataTable Listing_pr(string cText)
        {
            D_Products Data = new D_Products();
            return Data.Listing_pr(cText);
        }

        public static string Save_pr(int nOption, E_Products oPr)
        {
            D_Products Data = new D_Products();
            return Data.Save_pr(nOption, oPr);
        }

        public static string Delete_pr(int Id_pr)
        {
            D_Products Data = new D_Products();
            return Data.Delete_pr(Id_pr);
        }

        public static DataTable Listing_ma_pr(string cText)
        {
            D_Products Data = new D_Products();
            return Data.Listing_ma_pr(cText);
        }

        public static DataTable Listing_mu_pr(string cText)
        {
            D_Products Data = new D_Products();
            return Data.Listing_mu_pr(cText);
        }

        public static DataTable Listing_ca_pr(string cText)
        {
            D_Products Data = new D_Products();
            return Data.Listing_ca_pr(cText);
        }

        public static DataTable Stock_Actions(int Id_pr)
        {
            D_Products Data = new D_Products();
            return Data.Stock_Actions(Id_pr);
        }
    }
}
