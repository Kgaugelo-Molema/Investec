using Movies.Controllers;
using Movies.Helpers;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MovieTests
{
    public class ClientHelperTests
    {
        [Theory]
        [InlineData(ClientHelper.chuckUrl)]
        [InlineData(ClientHelper.swapiUrl)]
        [InlineData(ClientHelper.jokeUrl + "animal")]
        [InlineData(ClientHelper.peopleUrl + "Luke Skywalker")]
        public void GivenValidUrl_WhenRequesting_ThenReturnOk(string url)
        {
            var result = ClientHelper.GetMessage(null, url);
            Assert.Equal(HttpStatusCode.OK, result.Result.StatusCode);
        }
    }
}
