using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Minimarket.Entities
{
    public class E_Users
    {
        public int Id_us { get; set; }
        public string Login_us { get; set; }
        public string Password_us { get; set; }
        public string Names_us { get; set; }
        public string Location_us { get; set; }
        public bool Admin { get; set; }
    }
}
