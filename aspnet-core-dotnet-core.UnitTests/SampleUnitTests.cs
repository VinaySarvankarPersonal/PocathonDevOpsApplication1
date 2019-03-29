// <copyright file="SampleUnitTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aspnet_core_dotnet_core.UnitTests
{
    using Aspnet_core_dotnet_core.Controllers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SampleUnitTests
    {
        [TestMethod]
        public void IndexPageTest()
        {
            var controller = new HomeController();
            IActionResult result = controller.Index();
            Assert.AreEqual(null, controller.ViewData["Message"]);
        }

        [TestMethod]
        public void AboutPageTest()
        {
            var controller = new HomeController();
            IActionResult result = controller.About();
            Assert.AreEqual("Your application description page.", controller.ViewData["Message"]);
        }

        [TestMethod]
        public void ContactPageTest()
        {
            var controller = new HomeController();
            IActionResult result = controller.Contact();
            Assert.AreEqual("Your contact page.", controller.ViewData["Message"]);
        }
    }
}
