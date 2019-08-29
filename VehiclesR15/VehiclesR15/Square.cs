using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesR15
{
    class Vehicles
    {
        private string make;
        private string model;
        private string year;

        public Vehicles() { }

        public Vehicles(string make, string model,string year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Year { get => year; set => year = value; }

        public void Accelerate() { }
        public void Decelerate() { }
        
        public void Drive() { }

        public void Start () { }

        public void Stop() { }

    }
}
