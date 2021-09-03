using System;
using Xunit;
using WebWithTest.Controllers;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void IndexViewDataMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.Equal("Hello world!", result?.ViewData["Message"]);

        }
    }
}
