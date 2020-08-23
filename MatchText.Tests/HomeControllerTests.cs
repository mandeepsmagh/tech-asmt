using System;
using Xunit;
using MatchText.Controllers;
using Moq;
using MatchText.Services;
using Microsoft.AspNetCore.Mvc;

namespace MatchText.Tests
{
    public class HomeControllerTests
    {
        private readonly Mock<IMatchTextService> mockRepo;
        private readonly HomeController controller;

        public HomeControllerTests()
        {
            mockRepo = new Mock<IMatchTextService>();
            controller = new HomeController(mockRepo.Object);
        }

        [Fact]
        public void IndexActionReturnsViewResult()
        {
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }

    }
}
