using Responsive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HomeController_GetIndex()
        {
            Mock<ResponsiveModel> repo = new Mock<ResponsiveModel>();

            HomeController ctrl = new HomeController(repo.Object);
            var ret = ctrl.Index();
        }
    }
}