using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BT.Models
{
    public class Employee:Person
    {
        public string Conpany { get; set; }
        public string Adđress { get; set; }
    }
}