using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal abstract class PersonalVehicle : Vehicle, IParkable
    {
        public PersonalVehicle(string id, Color color, int seats, int size) : base(id, color)
        {
            Seats = seats;
            Size = size;
        }

        public int Seats { get; set; }

        public int Size { get; set; }

        public virtual float CalculatePrice(int hoursSpent /*, int Size, int Seats*/)
        {
            return Size * hoursSpent * Seats;
        }

        public override string ToString()
        {
            return Color.Name + " " + Id;
        }
    }
}
