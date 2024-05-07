using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Controllers;
using MobilePhoneStore.Interfaces;
using MobilePhoneStore.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MobilePhoneStoreTestProject.Controllers
{
    public class PhonesControllerTest
    {
        [Fact]
        public void GetPhone_ValidId_ReturnsObject()
        {
            // Arrange
            Phone phone = new Phone()
            {
                Id = 1,
                Model = "ModelTest",
                OperatingSystem = "OSTestName",
                AvailableQuantity = 20,
                Price = 1000,
                Photo = "TestPhoto",
                ManufacturerId = 1,
                Manufacturer = new Manufacturer { Id = 1, Name = "ManufacturerTestName", Country = "USA" }
            };

            PhoneDTO phoneDTO = new PhoneDTO()
            {
                Id = 1,
                Model = "ModelTest",
                OperatingSystem = "OSTestName",
                AvailableQuantity = 20,
                Price = 1000,
                Photo = "TestPhoto",
                ManufacturerId = 1,
                ManufacturerName = "ManufacturerTest"
            };

            var mockRepository = new Mock<IPhoneRepository>();
            mockRepository.Setup(x => x.GetById(1)).Returns(phone);

            var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(new PhoneProfile()));
            IMapper mapper = new Mapper(mapperConfiguration);

            var controller = new PhonesController(mockRepository.Object, mapper);

            // Act
            var actionResult = controller.GetPhone(1) as OkObjectResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.NotNull(actionResult.Value);

            PhoneDTO dtoResult = (PhoneDTO)actionResult.Value;
            Assert.Equal(phone.Id, dtoResult.Id);
            Assert.Equal(phone.Model, dtoResult.Model);
            Assert.Equal(phone.OperatingSystem, dtoResult.OperatingSystem);
            Assert.Equal(phone.AvailableQuantity, dtoResult.AvailableQuantity);
            Assert.Equal(phone.Price, dtoResult.Price);
            Assert.Equal(phone.ManufacturerId, dtoResult.ManufacturerId);
            Assert.Equal(phone.Manufacturer.Name, dtoResult.ManufacturerName);
        }

        [Fact]
        public void PutPhone_InvalidId_ReturnsBadRequest()
        {
            // Arrange
            Phone phone = new Phone()
            {
                Id = 1,
                Model = "ModelTest",
                OperatingSystem = "OSTestName",
                AvailableQuantity = 20,
                Price = 1000,
                Photo = "TestPhoto",
                ManufacturerId = 1,
                Manufacturer = new Manufacturer { Id = 1, Name = "ManufacturerTestName", Country = "USA" }
            };

            var mockRepository = new Mock<IPhoneRepository>();

            var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(new PhoneProfile()));
            IMapper mapper = new Mapper(mapperConfiguration);

            var controller = new PhonesController(mockRepository.Object, mapper);

            // Act
            var actionResult = controller.PutPhone(30, phone) as BadRequestResult;

            // Assert
            Assert.NotNull(actionResult);
        }

        [Fact]
        public void GetAllByPrice_ValidRequest_ReturnsCollection()
        {
            // Arrange
            int minimum = 20000;
            int maximum = 100000;

            var searchDto = new SearchDTO { Minimum = minimum, Maximum = maximum };

            List<Phone> phones = new List<Phone>() {
                new Phone()
                    {
                        Id = 1,
                        Model = "ModelTest",
                        OperatingSystem = "OSTestName",
                        AvailableQuantity = 20,
                        Price = 1000,
                        Photo = "TestPhoto",
                        ManufacturerId = 1,
                        Manufacturer = new Manufacturer { Id = 1, Name = "ManufacturerTestName", Country = "USA" }
                    },
                new Phone()
                    {
                        Id = 2,
                        Model = "ModelTest1",
                        OperatingSystem = "OSTestName1",
                        AvailableQuantity = 20,
                        Price = 1000,
                        Photo = "TestPhoto1",
                        ManufacturerId = 1,
                        Manufacturer = new Manufacturer { Id = 1, Name = "ManufacturerTestName1", Country = "USA" }
                    },
            };

            var mockRepository = new Mock<IPhoneRepository>();
            mockRepository.Setup(x => x.GetAllByPrice(It.IsAny<int>(), It.IsAny<int>())).Returns(phones.AsQueryable());

            var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(new PhoneProfile()));
            IMapper mapper = new Mapper(mapperConfiguration);

            var controller = new PhonesController(mockRepository.Object, mapper);

            // Act
            var actionResult = controller.Search(searchDto) as OkObjectResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.NotNull(actionResult.Value);

            List<PhoneDTO> listResult = (List<PhoneDTO>)actionResult.Value;

            for (int i = 0; i < listResult.Count; i++)
            {
                Assert.Equal(phones[i].Id, listResult[i].Id);
                Assert.Equal(phones[i].Model, listResult[i].Model);
                Assert.Equal(phones[i].OperatingSystem, listResult[i].OperatingSystem);
                Assert.Equal(phones[i].AvailableQuantity, listResult[i].AvailableQuantity);
                Assert.Equal(phones[i].Price, listResult[i].Price);
                Assert.Equal(phones[i].ManufacturerId, listResult[i].ManufacturerId);
                Assert.Equal(phones[i].Manufacturer.Name, listResult[i].ManufacturerName);
            }
        }
    }
}
