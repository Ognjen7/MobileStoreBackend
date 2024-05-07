using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Controllers;
using MobilePhoneStore.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MobilePhoneStoreTestProject.Controllers
{
    public class ManufacturersControllerTest
    {
        [Fact]
        public void GetManufacturer_InvalidId_ReturnsNotFound()
        {
            // Arrange
            var mockRepository = new Mock<IManufacturerRepository>();

            var controller = new ManufacturersController(mockRepository.Object);

            // Act
            var actionResult = controller.GetManufacturer(12) as NotFoundResult;

            // Assert
            Assert.NotNull(actionResult);
        }
    }
}
