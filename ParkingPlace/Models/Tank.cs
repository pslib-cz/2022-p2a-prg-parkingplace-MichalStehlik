using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Tank : Vehicle
    {
        public int Size { get; }
        public Tank(string id, Color color) : base(id, color)
        {
        }

        public override string ToString()
        {
            return "Tank " + Color.Name + " " + Id;
        }
        public float CalculatePrice(int hours)
        {
            return 10000;
        }
    }
}
