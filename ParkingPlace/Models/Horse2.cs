using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Horse2
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != "Tonda")
                    _name = value;
            }
        }

        public string Id { get; private set; }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string x)
        {
            if (x != "Tonda")
                _name = x;
        }

        public Horse2()
        {
            _name = "Ferda";
            Id = "DDDDDD";
        }

        public Horse2(string n)
        {
            _name = n;
        }
    }
}
