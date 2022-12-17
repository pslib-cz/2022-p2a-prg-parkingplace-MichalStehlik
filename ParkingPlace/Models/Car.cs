using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Car : PersonalVehicle
    {
        public Car(string id, Color color, int seats) : base(id, color, seats, 1)
        {
        }

        public override float CalculatePrice(int hours)
        {
            return 15 * hours;
        }

        public override string ToString()
        {
            return "Car " + base.ToString();
        }
    }
}
