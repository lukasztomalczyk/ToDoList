FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

COPY . ./
# RUN dotnet restore
# cd ToDoList.api/ &&
RUN cd ToDoList.api/ && dotnet publish -c Release -o bin/Docker/

ENV ASPNETCORE_ENVIRONMENT Docker
ENV ASPNETCORE_URLS "http://*:5000"

ENTRYPOINT ["dotnet", "./ToDoList.api/bin/Docker/ToDoList.api.dll"]