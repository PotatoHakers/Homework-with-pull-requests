using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Entites
{
    public class Building
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public int? Floor { get; set; }
        public double? Area { get; set; }
        public int RoomCount { get; set; }
    }
}
