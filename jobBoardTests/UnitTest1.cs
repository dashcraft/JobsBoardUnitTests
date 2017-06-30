using System;
using Xunit;
using reverseJobsBoard.Controllers;


namespace jobBoardTests
{
    public class JobBoardTest
    {
        [Fact]
        public void GenericTest()
        {
            Assert.Contains("Hel","Hello");
            var ctrl = new HomeController();


        }
    }
}
