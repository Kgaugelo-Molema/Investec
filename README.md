# Movies API

## Deploy locally
* Install [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet)

* Execute (cd $MoviesSolutionDir\Movies) `dotnet dev-certs https` to generate a certificate 
* Bootstrap command `$MoviesSolutionDir\bootstrap.bat`

Open https://localhost:5001/swagger/index.html to explore the API.

# Manage users
![alt text](images\users-endpoint.png)

## Register user
![alt text](images\register-user.png)

## Generate user token
![alt text](images\auth-user.png)
![alt text](images\token.png)

## Authenticate user using token
Click the lock icon on the Users endpoint, prepend the value with **bearer** and paste the generated token. Click **Authorize**.
![alt text](images\token-auth.png)

## Request list of registered users
![alt text](images\user-list.png)
