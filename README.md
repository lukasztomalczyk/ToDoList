<h2>
ToDoList
</h2>


<img src="https://travis-ci.org/lukasztomalczyk/ToDoList.svg?branch=master">

This is my small project. A simple application is the organization of tasks. The application is made using dotnet core 2.0 and Nhibernate as a database. In the future, I will put an angular app on the fron-end side

Applications can be downloaded from the hub docker:
- <a href="https://hub.docker.com/r/lukasztomalczyk/todolist/">https://hub.docker.com/r/lukasztomalczyk/todolist</a>
- `docker pull lukasztomalczyk/todolist`

<h1>Used packages</h1>
* Swashbuckle.AspNetCore Version="2.5.0"
* FluentNHibernate Version="2.1.2"
* Moq Version="4.8.3"
* NUnit" Version="3.10.1"
* FluentAssertions" Version="5.4.0"

Use the swagger to view the API documentation
`http://localhost:[port]/swagger/`

- Available requests:
 <b>GET</b> by id `curl -X GET "http://localhost:5000/api/ToDoList/GetById/1" -H "accept: text/plain"`
     endpoint: `http://localhost:5000/api/ToDoList/GetById/1`
<b>GET</b> all resources `curl -X GET "http://localhost:5000/api/ToDoList/GetAll" -H "accept: text/plain"`
     enpoint: `http://localhost:5000/api/ToDoList/GetAll`
<b>POST</p>
```
{
  "id": 0,
  "name": "string",
  "description": "string",
  "creationDate": "datetime",
  "dateOfCompletion": "datetime",
  "isDone": true
}
```
    endpoint: `http://localhost:5000/api/ToDoList`
