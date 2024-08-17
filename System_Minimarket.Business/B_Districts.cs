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
    public class B_Districts
    {
        public static DataTable Listing_di(string cText)
        {
            D_Districts Data = new D_Districts();
            return Data.Listing_di(cText);
        }

        public static string Save_di(int nOption, E_Districts oPr)
        {
            D_Districts Data = new D_Districts();
            return Data.Save_di(nOption, oPr);
        }

        public static string Delete_di(int Id_pr)
        {
            D_Districts Data = new D_Districts();
            return Data.Delete_di(Id_pr);
        }

        public static DataTable Listing_po_personalized(string cText)
        {
            D_Districts d_Districts = new D_Districts();
            return d_Districts.Listing_po_personalized(cText);
        }
    }
}
