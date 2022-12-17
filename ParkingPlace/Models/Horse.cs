using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Horse : object, IParkable
    {
        public Horse(string id)
        {
            Id = id;
            Size = 1;
        }

        public string Id { get; set; }
        public int Size { get; set; }
        public float CalculatePrice(int hours)
        {
            return 1 * hours;
        }

        public override string ToString() 
        {
            return "Kůň " + Id;
        }
    }
}
