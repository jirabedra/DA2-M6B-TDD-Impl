using CarRentalLogicInterface;
using CarRentalManagementApi.Controllers;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CarRentalManagementApiTest.Test
{
    [TestClass]
    public class PlateControllerTest
    {
        [TestMethod]
        public void GetAllPlatesOk()
        {
            //Arrange
            IEnumerable<Plate> expectedPlates = new List<Plate>()
            {
                new Plate()
                {
                    Code = "SBL 1000",
                    EmittedDate = new DateTime(2022, 9, 12),
                    City = "Montevideo"
                },new Plate()
                {
                    Code = "TSD 1000",
                    EmittedDate = new DateTime(2022, 9, 12),
                    City = "Montevideo"
                }
            };

            var logicMock = new Mock<IPlateLogic>(MockBehavior.Strict);
            PlateController plateController = new PlateController(logicMock.Object);
            logicMock.Setup(m => m.GetAllPlates()).Returns(expectedPlates);


            //Act
            var result = plateController.GetAllPlates();
            var okObjectResult = result as OkObjectResult;
            var returnedValue = okObjectResult.Value as IEnumerable<Plate>;

            //Assert
            logicMock.VerifyAll();
            Assert.IsTrue(expectedPlates.SequenceEqual(returnedValue));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddAlreadyExistingPlate()
        {
            //Arrange
            Plate plate = new Plate()
            {
                Code = "TSD 1000",
                EmittedDate = new DateTime(2022, 9, 12),
                City = "Montevideo"
            };

            var logicMock = new Mock<IPlateLogic>(MockBehavior.Strict);
            logicMock.Setup(t => t.AddPlate(It.IsAny<Plate>())).Throws<ArgumentException>();
            PlateController plateController = new PlateController(logicMock.Object);

            //Act
            var result = plateController.AddPlate(plate);

            //Assert
            logicMock.VerifyAll();
            Assert.ThrowsException<ArgumentException>(() => plateController.AddPlate(plate));
        }

        [TestMethod]
        public void AddPlateOk()
        {
            //Arrange
            Plate plate = new Plate()
            {
                Code = "TSD 1000",
                EmittedDate = new DateTime(2022, 9, 12),
                City = "Montevideo"
            };

            var logicMock = new Mock<IPlateLogic>(MockBehavior.Strict);
            logicMock.Setup(t => t.AddPlate(It.IsAny<Plate>())).Returns(plate);
            PlateController plateController = new PlateController(logicMock.Object);

            //Act
            var result = plateController.AddPlate(plate);
            var createdAtRouteResult = result as CreatedAtRouteResult;
            var returnedValue = createdAtRouteResult.Value as Plate;

            //Assert
            logicMock.VerifyAll();
            Assert.AreEqual(returnedValue, plate);
        }


    }
}
