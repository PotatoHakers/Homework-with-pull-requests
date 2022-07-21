using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Entites
{
    [Table ("Flats")]
    public class Flat : Building
    {
        public int FlatId { get; set; }
        
        public int FloorApartment { get; set; }
        public bool Balcony { get; set; }
        public double Price { get; set; }
        public List<Client> Clients { get; set; } = new List<Client>();
        
    }
}
