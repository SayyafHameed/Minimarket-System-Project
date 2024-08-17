using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Minimarket.Entities
{
    public class E_Products
    {
        public int Id_pr { get; set; }
        public string Description_pr { get; set; }
        public int Id_ma { get; set; }
        public int Id_mu { get; set; }
        public int Id_ca { get; set; }
        public decimal Stock_min { get; set; }
        public decimal Stock_max { get; set; }
        public decimal Buy { get; set; }
    }
}
