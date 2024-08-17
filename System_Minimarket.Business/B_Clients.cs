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
    public class B_Clients
    {
        public static DataTable Listing_cl(string cText)
        {
            D_Clients Data = new D_Clients();
            return Data.Listing_cl(cText);
        }

        public static string Save_cl(int nOption, E_Clients oClient)
        {
            D_Clients Data = new D_Clients();
            return Data.Save_cl(nOption, oClient);
        }

        public static string Delete_cl(int Id_su)
        {
            D_Clients Data = new D_Clients();
            return Data.Delete_cl(Id_su);
        }

        public static DataTable Listing_tdsc()
        {
            D_Clients Data = new D_Clients();
            return Data.Listing_tdsc();
        }

        public static DataTable Listing_ge()
        {
            D_Clients Data = new D_Clients();
            return Data.Listing_ge();
        }

        public static DataTable Listing_it_cl(string cText)
        {
            D_Clients Data = new D_Clients();
            return Data.Listing_it_cl(cText);
        }

        public static DataTable Listing_di_cl(string cText)
        {
            D_Clients Data = new D_Clients();
            return Data.Listing_di_cl(cText);
        }
    }
}
