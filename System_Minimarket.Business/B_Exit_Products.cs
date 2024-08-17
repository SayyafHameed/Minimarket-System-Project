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
    public class B_Exit_Products
    {
        public static DataTable Listing_exp(string cText)
        {
            D_Exit_Products Data = new D_Exit_Products();
            return Data.Listing_exp(cText);
        }

        public static DataTable Listing_Detail_exp(int nId_ep)
        {
            D_Exit_Products Data = new D_Exit_Products();
            return Data.Listing_Detail_exp(nId_ep);
        }

        public static string Save_exp(E_Exit_Products oEp, DataTable dTable)
        {
            D_Exit_Products Data = new D_Exit_Products();
            return Data.Save_exp(oEp, dTable);
        }

        public static string Delete_exp(int Id_su)
        {
            D_Exit_Products Data = new D_Exit_Products();
            return Data.Delete_exp(Id_su);
        }

        public static DataTable Listing_tdi()
        {
            D_Exit_Products Data = new D_Exit_Products();
            return Data.Listing_tdi();
        }

        public static DataTable Listing_cl_exp(string cText)
        {
            D_Exit_Products Data = new D_Exit_Products();
            return Data.Listing_cl_exp(cText);
        }

        public static DataTable Listing_pr_exp(string cText)
        {
            D_Exit_Products Data = new D_Exit_Products();
            return Data.Listing_pr_exp(cText);
        }
    }
}
