FROM microsoft/dotnet:2.2-aspnetcore-runtime

COPY DemoApi/bin/Release/netcoreapp2.2/ app/

ENTRYPOINT ["dotnet", "app/DemoApi.dll"]
