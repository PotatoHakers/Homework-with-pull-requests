using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Entites
{
    [Table ("Offices")]
    public class Office : Building
    {
        public int OfficeId { get; set; }
        public int FloorAppartament { get; set; }
        public double Price { get; set; }

    }
    
}
