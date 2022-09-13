using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalLogicInterface.Interfaces
{
    public interface ICarLogic
    {
        public List<Car> GetAllCars();
        public Car GetCarByPlate(string plate);
        public void AddCar(Car car);
        public void RemoveCarByPlate(string plate);
        public void UpdateCar(string plate, Car newCar);
    }
}
