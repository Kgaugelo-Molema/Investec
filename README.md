## Phonebook Register
Install the following before deploying to your machine:
* Visual Studio 2019
* .Net Core 3

## Deploy locally
* Build solution `dotnet build $MoviesSolutionDir`
* Build solution `dotnet test $MoviesSolutionDir`
* Generate certificate ($MoviesSolutionDir\Movies) `dotnet dev-certs https`
* Run REST API - `dotnet run --project $MoviesSolutionDir\Movies\Movies.csproj`

Open https://localhost:5001/swagger/index.html to explore the site.
