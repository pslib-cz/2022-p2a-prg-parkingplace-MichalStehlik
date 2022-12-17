using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Bus : PersonalVehicle
    {
        public Bus(string id, Color color, int seats) : base(id, color, seats, 5)
        {
        }

        public override float CalculatePrice(int hours)
        {
            return 200 + base.CalculatePrice(hours);
        }
        public override string ToString()
        {
            return "Bus " + base.ToString() + " with " + Seats + " seats";
        }
    }
}
