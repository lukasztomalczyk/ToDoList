FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

COPY . ./

RUN dotnet restore

ENV ASPNETCORE_ENVIRONMENT Production

RUN cd ToDoList.api/ && dotnet publish -c Release -o bin/Docker/

WORKDIR /app/ToDoList.api/bin/Docker

ENV ASPNETCORE_URLS "http://*:5001"

ENTRYPOINT ["dotnet", "ToDoList.api.dll"]
