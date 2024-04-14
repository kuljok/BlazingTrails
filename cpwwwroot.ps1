$ErrorActionPreference = "Stop"

dotnet build BlazingTrails.Api
dotnet publish BlazingTrails.Client --configuration Debug --output ./pubclient
cp -r ./pubclient/wwwroot ./BlazingTrails.Api/bin/Debug/net6.0/wwwroot
rm -r ./pubclient

