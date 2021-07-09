using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using MVC_2.Controllers;
using MVC_2.Models;
using MVC_2.Services;
using NUnit.Framework;


namespace MVC_2Tests
{
    public class RookiesControllerTests
    {

        private static List<PersonModel> _data = new List<PersonModel>()
        {
            new PersonModel
            {
                id=1,
                firstName="hieu1",
                lastName="do1",
                dateOfBirth = new DateTime (2000,08,09),
                gender="nam",
                phoneNumber=123456789,
                birthPlace="HN",
                age=10,
                isGraduated=true,
                email="hieu@gmai.com"
            },
            new PersonModel
            {
                id=2,
                firstName="hieu2",
                lastName="do2",
                dateOfBirth = new DateTime (2000,08,09),
                gender="nu",
                phoneNumber=123456789,
                birthPlace="HCM",
                age=10,
                isGraduated=true,
                email="hieu@gmai.com"
            },
            new PersonModel
            {
                id=3,
                firstName="hieu3",
                lastName="do3",
                dateOfBirth = new DateTime (2000,08,09),
                gender="nam",
                phoneNumber=123456789,
                birthPlace="QN",
                age=10,
                isGraduated=true,
                email="hieu@gmai.com"
            },
        };
        private Mock<ILogger<RookiesController>> _loggerMock;
        private Mock<IService> _serviceMock;
        [SetUp]
        public void Setup()
        {
            _loggerMock = new Mock<ILogger<RookiesController>>();
            _serviceMock = new Mock<IService>();
            _serviceMock.Setup(s => s.GetAll()).Returns(_data);

        }

        [Test]
        public void Index_ReturnViewresult_WithAListPersons()
        {
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);
            // Act
            var result = controller.Index();
            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            var view = (ViewResult)result;
            Assert.IsAssignableFrom<List<PersonModel>>(view.ViewData.Model);
            var list = (List<PersonModel>)view.ViewData.Model;
            Assert.AreEqual(_data.Count, list.Count);
        }
        [Test]
        public void Detail_ReturnsHttpNotFound_ForInvalidId()
        {
            // Arrange
            const int personId = 9999;
            _serviceMock.Setup(service => service.Get(personId)).Returns((PersonModel)null);
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);

            // Act
            var result = controller.Details(personId);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

        [Test]
        public void Detail_ReturnsAPerson()
        {
            // Arrange
            const int personId = 1;
            _serviceMock.Setup(service => service.Get(personId)).Returns(_data.FirstOrDefault(p => p.id == personId));
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);
            const string expectedFirstName = "hieu1";

            // Act
            var result = controller.Details(personId);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsAssignableFrom<PersonModel>(((ViewResult)result).ViewData.Model);
            Assert.AreEqual(expectedFirstName, ((PersonModel)((ViewResult)result).ViewData.Model).firstName);
        }

        [Test]
        public void Create_ReturnsBadRequest_GivenInvalidModel()
        {
            // Arrange
            const string message = "some error";
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);
            controller.ModelState.AddModelError("error", message);

            // Act
            var result = controller.Create(person: null);

            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
            Assert.IsAssignableFrom<SerializableError>(((BadRequestObjectResult)result).Value);

            var error = (SerializableError)((BadRequestObjectResult)result).Value;
            Assert.AreEqual(1, error.Count);

            error.TryGetValue("error", out var msg);
            Assert.IsNotNull(msg);
            Assert.AreEqual(message, ((string[])msg).First());
        }
        [Test]
        public void Create_ReturnAPerson()
        {
            // Arrange
            int testId = 4;
            string testFirstName = "hieu4";
            string testLastName = "do";
            DateTime testDateOfBirth = new DateTime(2000, 08, 09);
            string testGender = "nu";
            int testPhoneNumber = 123456789;
            string testBirthPlace = "HN";
            int testAge = 10;
            bool testIsGraduated = true;
            string testEmail = "hieu@gmail.com";
            var testPerson = new PersonModel()
            {
                id = testId,
                firstName = testFirstName,
                lastName = testLastName,
                dateOfBirth = new DateTime(2000, 08, 09),
                gender = testGender,
                phoneNumber = testPhoneNumber,
                birthPlace = testBirthPlace,
                age = testAge,
                isGraduated = testIsGraduated,
                email = testEmail
            };
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);

            // Act
            var result = controller.Create(testPerson);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
           
        }

        [Test]
        public void Edit_ReturnsHttpNotFound_ForInvalidId()
        {
            // Arrange
            const int personId = 9999;
            _serviceMock.Setup(service => service.Get(personId)).Returns((PersonModel)null);
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);

            // Act
            var result = controller.Edit(personId);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);

        }
        [Test]
        public void Edit_ReturnsAPerson()
        {
            // Arrange
            const int personId = 1;
            _serviceMock.Setup(service => service.Get(personId)).Returns(_data.FirstOrDefault(p => p.id == personId));
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);
            const string expectedFirstName = "hieu1";

            // Act
            var result = controller.Edit(personId);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsAssignableFrom<PersonModel>(((ViewResult)result).ViewData.Model);
            Assert.AreEqual(expectedFirstName, ((PersonModel)((ViewResult)result).ViewData.Model).firstName);
        }
        [Test]
        public void Delete_ReturnsHttpNotFound_ForInvalidId()
        {
            // Arrange
            const int personId = 9999;
            _serviceMock.Setup(service => service.Get(personId)).Returns((PersonModel)null);
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);

            // Act
            var result = controller.Delete(personId);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }
         [Test]
        public void Delete_ReturnsAPerson()
        {
            // Arrange
            const int personId = 1;
            _serviceMock.Setup(service => service.Get(personId)).Returns(_data.FirstOrDefault(p => p.id == personId));
            var controller = new RookiesController(_serviceMock.Object, _loggerMock.Object);
            const string expectedFirstName = "hieu1";

            // Act
            var result = controller.Delete(personId);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsAssignableFrom<PersonModel>(((ViewResult)result).ViewData.Model);
            Assert.AreEqual(expectedFirstName, ((PersonModel)((ViewResult)result).ViewData.Model).firstName);
        }
    }
}