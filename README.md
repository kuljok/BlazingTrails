# Building a BlazingTrails solution

## Building the solution

The default project is the BlazingTrails.Api project as it provides the API for the BlazingTrails application. Also it builds and run the client project as a part of the build process. Additionally the client authentication is configured to use the callback URL http://localhost:5104/authentication/login-callback which is used by API project.

## Run the Api project

Execute the following command to run the API project:

```shell
cd BlazingTrails.Api
dotnet run
```
