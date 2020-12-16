  FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim
  COPY bin/Release/net5.0/publish/ App/
  WORKDIR /App
  EXPOSE 80
  ENTRYPOINT ["dotnet", "Ordering.API.dll"]