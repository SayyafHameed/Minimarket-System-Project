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
    public class B_Departments
    {
        public static DataTable Listing_de(string cText)
        {
            D_Departments Data = new D_Departments();
            return Data.Listing_de(cText);
        }

        public static string Save_de(int nOption, E_Departments oPr)
        {
            D_Departments Data = new D_Departments();
            return Data.Save_de(nOption, oPr);
        }

        public static string Delete_de(int Id_pr)
        {
            D_Departments Data = new D_Departments();
            return Data.Delete_de(Id_pr);
        }
    }
}
