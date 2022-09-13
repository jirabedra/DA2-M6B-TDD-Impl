using CarRentalLogicInterface.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalLogic.Logics
{
    public class CarLogic : ICarLogic
    {
        public List<Car> Cars { get; set; } = new List<Car>
        {
            new Car{Manufacturer = "Volkswagen", Model = "Up!", Plate = "ASD 1111"},
            new Car{Manufacturer = "Chevrolet", Model = "Tracker", Plate = "CSB 2222"},
            new Car{Manufacturer = "Suzuki", Model = "Celerio", Plate = "SCB 3333"},
            new Car{Manufacturer = "Mitsubishi", Model = "Mirage", Plate = "VFE 4444"},
            new Car{Manufacturer = "BMW", Model = "X1", Plate = "NJE 5555"}
        };

       

        public List<Car> GetAllCars()
        {
            return Cars;
        }

        public Car GetCarByPlate(string plate)
        {
            var found = Cars.FirstOrDefault(c => c.Plate == plate);
            if(found is null)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return found;
            }
        }

        public void AddCar(Car car)
        {
            //todo
        }

        public void RemoveCarByPlate(string plate)
        {
            //todo
        }

        public void UpdateCar(string plate, Car newCar)
        {
            //todo
        }
    }
}
