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
    public class B_Enter_Products
    {
        public static DataTable Listing_ep(string cText)
        {
            D_Enter_Products Data = new D_Enter_Products();
            return Data.Listing_ep(cText);
        }

        public static DataTable Listing_Detail_ep(int nId_ep)
        {
            D_Enter_Products Data = new D_Enter_Products();
            return Data.Listing_Detail_ep(nId_ep);
        }

        public static string Save_ep(E_Enter_Products oEp, DataTable dTable)
        {
            D_Enter_Products Data = new D_Enter_Products();
            return Data.Save_ep(oEp, dTable);
        }

        public static string Delete_ep(int Id_su)
        {
            D_Enter_Products Data = new D_Enter_Products();
            return Data.Delete_ep(Id_su);
        }

        public static DataTable Listing_tdi()
        {
            D_Enter_Products Data = new D_Enter_Products();
            return Data.Listing_tdi();
        }

        public static DataTable Listing_st_ep()
        {
            D_Enter_Products Data = new D_Enter_Products();
            return Data.Listing_st_ep();
        }

        public static DataTable Listing_su_ep(string cText)
        {
            D_Enter_Products Data = new D_Enter_Products();
            return Data.Listing_su_ep(cText);
        }

        public static DataTable Listing_pr_ep(string cText)
        {
            D_Enter_Products Data = new D_Enter_Products();
            return Data.Listing_pr_ep(cText);
        }
    }
}
