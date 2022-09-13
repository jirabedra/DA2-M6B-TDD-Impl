using CarRentalLogicInterface;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalLogic.Logics
{
    public class PlateLogic : IPlateLogic
    {
        public Plate AddPlate(Plate plate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plate> GetAllPlates()
        {
            return new List<Plate>()
            {
                new Plate()
                {
                    Code = "SBL 1000",
                    EmittedDate = new DateTime(2022, 9, 12),
                    City = "Montevideo"
                },
                new Plate()
                {
                    Code = "TSD 1000",
                    EmittedDate = new DateTime(2022, 9, 12),
                    City = "Montevideo"
                }
            };
        }
    }
}
