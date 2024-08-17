using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Minimarket.Entities
{
    public class E_Clients
    {
        public int Id_cl { get; set; }
        public int Id_tdsc { get; set; }
        public string NoDocument_cl { get; set; }
        public string CompanyName_cl { get; set; }
        public string Numbers { get; set; }
        public string SurNames { get; set; }
        public int Id_ge { get; set; }
        public int Id_it { get; set; }
        public string Email_cl { get; set; }
        public string Phone_cl { get; set; }
        public string Mobile_cl { get; set; }
        public string Address_cl { get; set; }
        public int Id_di { get; set; }
        public string Observation_cl { get; set; }
    }
}
