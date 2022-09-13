using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Plate { get; set; }

        public override bool Equals(object obj)
        {
            var car = obj as Car;
            if(car is null)
            {
                return false;
            }
            return this.Plate.Equals(car.Plate);
        }
    }

    
}
