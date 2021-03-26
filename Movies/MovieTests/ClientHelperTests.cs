using Movies.Controllers;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MovieTests
{
    public class ClientHelperTests
    {
        const string categories = "[\"animal\",\"career\",\"celebrity\",\"dev\",\"explicit\",\"fashion\",\"food\",\"history\",\"money\",\"movie\",\"music\",\"political\",\"religion\",\"science\",\"sport\",\"travel\"]";
        const string json = " \"name\": \"Luke Skywalker\", \"height\": \"172\", \"mass\": \"77\", \"hair_color\": \"blond\", \"skin_color\": \"fair\", \"eye_color\": \"blue\", \"birth_year\": \"19BBY\", \"gender\": \"male\", \"homeworld\": \"http:////swapi.dev//api//planets//1//\", \"films\": [ \"http:////swapi.dev//api//films//1//\", \"http:////swapi.dev//api//films//2//\", \"http:////swapi.dev//api//films//3//\", \"http:////swapi.dev//api//films//6//";

        [Theory]
        [InlineData(ClientHelper.chuckUrl)]
        [InlineData(ClientHelper.swapiUrl)]
        public void GivenUrl_WhenRequesting_ThenReturnOk(string url)
        {
            var result = ClientHelper.GetMessage(null, url);
            Assert.Equal(HttpStatusCode.OK, result.Result.StatusCode);
        }
    }
}
