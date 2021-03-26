using Movies.Controllers;
using System;
using System.Net.Http;
using Xunit;

namespace MovieTests
{
    public class ChuckTests
    {
        [Fact]
        public void CanReturnCategories()
        {
            const string expected = "[\"animal\",\"career\",\"celebrity\",\"dev\",\"explicit\",\"fashion\",\"food\",\"history\",\"money\",\"movie\",\"music\",\"political\",\"religion\",\"science\",\"sport\",\"travel\"]";

            //var result = ChuckController.GetMessage();
            var result = ClientHelper.GetMessage(null, ClientHelper.chuckUrl);
            Assert.Equal(expected, result.Result);
        }
    }
}
