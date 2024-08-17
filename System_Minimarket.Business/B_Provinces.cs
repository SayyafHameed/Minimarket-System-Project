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
    public class B_Provinces
    {
        public static DataTable Listing_po(string cText)
        {
            D_Provinces Data = new D_Provinces();
            return Data.Listing_po(cText);
        }

        public static string Save_po(int nOption, E_Provinces oPr)
        {
            D_Provinces Data = new D_Provinces();
            return Data.Save_po(nOption, oPr);
        }

        public static string Delete_po(int Id_pr)
        {
            D_Provinces Data = new D_Provinces();
            return Data.Delete_po(Id_pr);
        }

        public static DataTable Listing_de_po(string cText)
        {
            D_Provinces d_Provinces = new D_Provinces();
            return d_Provinces.Listing_de_po(cText);
        }
    }
}
