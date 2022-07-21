using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Entites
{
    [Table("Realtor")]
    public class Realtor: Worker
    {
        public int RealtorId { get; set; }
        public string Office { get; set; }
        public string FieldActivity { get; set; }
        
    }
}
