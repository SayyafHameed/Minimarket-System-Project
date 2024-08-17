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
    public class B_Measured_Units
    {
        public static DataTable Listing_mu(string cText)
        {
            D_Measured_Units Data = new D_Measured_Units();
            return Data.Listing_mu(cText);
        }

        public static string Save_mu(int nOption, E_Measured_Units oMu)
        {
            D_Measured_Units Data = new D_Measured_Units();
            return Data.Save_mu(nOption, oMu);
        }

        public static string Delete_mu(int Id_pr)
        {
            D_Measured_Units Data = new D_Measured_Units();
            return Data.Delete_mu(Id_pr);
        }
    }
}
