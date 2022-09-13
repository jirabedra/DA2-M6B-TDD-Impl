using Domain;
using System;
using System.Collections.Generic;

namespace CarRentalLogicInterface
{
    public interface IPlateLogic
    {
        Plate AddPlate(Plate plate);
        IEnumerable<Plate> GetAllPlates();
    }
}