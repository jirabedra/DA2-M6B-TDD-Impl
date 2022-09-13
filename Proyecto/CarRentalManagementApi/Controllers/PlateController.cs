using CarRentalLogicInterface;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CarRentalManagementApi.Controllers
{
    [ApiController]
    [Route("api/plates")]
    public class PlateController
    {

        public IPlateLogic PlateLogic { get; set; }
        public PlateController(IPlateLogic aLogic)
        {
            PlateLogic = aLogic;
        }

        [HttpGet]
        public IActionResult GetAllPlates()
        {
            return new OkObjectResult(PlateLogic.GetAllPlates());
        }

        [HttpPost]
        public IActionResult AddPlate([FromBody] Plate plate)
        {
            return new CreatedAtRouteResult("/api/plates/" + plate.Code, PlateLogic.AddPlate(plate));
        }
    }
}