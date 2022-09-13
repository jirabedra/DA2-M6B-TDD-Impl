using CarRentalLogic.Logics;
using CarRentalLogicInterface.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Controllers
{
    [Route("/api/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private ICarLogic carLogic;

        public CarController(ICarLogic aCarLogic)
        {
            carLogic = aCarLogic;
        }

        [HttpGet]
        public IActionResult GetAllCars()
        {
            return new OkObjectResult(carLogic.GetAllCars());
        }

        [HttpGet("{manufacturer}")]
        public IActionResult GetCarByManufacturer([FromRoute] string plate)
        {
            var car = carLogic.GetCarByPlate(plate);
            if(car is null)
            {
                return NotFound();
            }
            else
            {
                return new OkObjectResult(car);
            }
        }

        [HttpDelete("{plate}")]
        public IActionResult DeleteCarByPlate([FromRoute] string plate)
        {
            try
            {
                carLogic.RemoveCarByPlate(plate);
                return Ok();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult AddCar([FromBody] Car car)
        {
            carLogic.AddCar(car);
            return Ok(car);
        }
    }
}
