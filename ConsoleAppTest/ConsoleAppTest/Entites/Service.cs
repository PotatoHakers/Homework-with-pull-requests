using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppTest.Entites
{
    public  class Service
    {
        public int ServiceId { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        
        public Deal? Deal { get; set; }
    }
}
