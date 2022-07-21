using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Entites
{
    [Table ("Houses")]
    public class House : Building
    {
        public int HouseId { get; set; }

        public double Price { get; set; }

    }
}
