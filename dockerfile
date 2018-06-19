FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

COPY . ./
# RUN dotnet restore
# cd ToDoList.api/ &&

ENV ASPNETCORE_ENVIRONMENT Production
RUN printenv
RUN cd ToDoList.api/ && dotnet publish -c Release -o bin/Docker/
RUN cd ToDoList.api/bin/Docker/ && ls -a


ENV ASPNETCORE_URLS "http://*:5000"

ENTRYPOINT ["dotnet", "./ToDoList.api/bin/Docker/ToDoList.api.dll"]
