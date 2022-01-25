using CodeReviewExample.BusinessLogic.Managers;
using CodeReviewExample.Client.Abstractions.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeReviewExample.BusinessLogic.Tests.Managers
{
    [TestClass]
    public class CalculatorManagerTests
    {
        [TestMethod]
        public void RunTest()
        {
            CalculatorManager manager = new CalculatorManager();
            RequestModel request = new RequestModel
            {
                Ids = { "1", "2", "3" }
            };
            ResponseModel response =  manager.Run(request);
            Assert.AreEqual(0.754520797987711, response.Values[0]);
            Assert.AreEqual(0.34559240999892, response.Values[1]);
            Assert.AreEqual(0.18268394571854, response.Values[2]);
        }
    }
}