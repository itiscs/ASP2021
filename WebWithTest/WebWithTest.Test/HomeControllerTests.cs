using Microsoft.AspNetCore.Mvc;
using WebWithTest.Controllers;
using Xunit;

namespace UnitTestApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexViewDataMessage()
        {
            // Arrange
            HomeController controller = new HomeController(null);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.Equal("Hello world!", result?.ViewData["Message"]);
        }

        [Fact]
        public void IndexViewResultNotNull()
        {
            // Arrange
            HomeController controller = new HomeController(null);
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void IndexViewNameEqualIndex()
        {
            // Arrange
            HomeController controller = new HomeController(null);
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.Equal("Index", result?.ViewName);
        }

        [Fact]
        public void PrivacyIsActionResult()
        {
            // Arrange
            HomeController controller = new HomeController(null);
            // Act
            ViewResult result = controller.Privacy() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }
    }
}