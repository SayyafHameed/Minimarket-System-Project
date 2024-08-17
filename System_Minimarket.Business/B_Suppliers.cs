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
    public class B_Suppliers
    {
        public static DataTable Listing_su(string cText)
        {
            D_Suppliers Data = new D_Suppliers();
            return Data.Listing_su(cText);
        }

        public static string Save_su(int nOption, E_Suppliers oSu)
        {
            D_Suppliers Data = new D_Suppliers();
            return Data.Save_su(nOption, oSu);
        }

        public static string Delete_su(int Id_su)
        {
            D_Suppliers Data = new D_Suppliers();
            return Data.Delete_su(Id_su);
        }

        public static DataTable Listing_tdsc()
        {
            D_Suppliers Data = new D_Suppliers();
            return Data.Listing_tdsc();
        }

        public static DataTable Listing_ge()
        {
            D_Suppliers Data = new D_Suppliers();
            return Data.Listing_ge();
        }

        public static DataTable Listing_it_su(string cText)
        {
            D_Suppliers Data = new D_Suppliers();
            return Data.Listing_it_su(cText);
        }

        public static DataTable Listing_di_su(string cText)
        {
            D_Suppliers Data = new D_Suppliers();
            return Data.Listing_di_su(cText);
        }
    }
}
