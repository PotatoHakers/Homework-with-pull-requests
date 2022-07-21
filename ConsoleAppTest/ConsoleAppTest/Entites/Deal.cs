using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Entites
{
    public class Deal
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        
    }
}
