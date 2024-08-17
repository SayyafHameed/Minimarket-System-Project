using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Minimarket.Entities
{
    public class E_Enter_Products
    {
        public int Id_ep { get; set; }
        public int Id_tdi { get; set; }
        public string noDocument_ep { get; set; }
        public int Id_su { get; set; }
        public DateTime Data_ep { get; set; }
        public int Id_st { get; set; }
        public string Observation { get; set; }
        public decimal Subtotal { get; set; }
        public decimal igv { get; set; }
        public decimal total_amount { get; set; }
    }
}
