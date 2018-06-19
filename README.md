<h1>
ToDoList v1
</h1>


<img src="https://travis-ci.org/lukasztomalczyk/ToDoList.svg?branch=master">

This is my small project. A simple application is the organization of tasks. The application is made using dotnet core 2.0 and Nhibernate as a database. In the future, I will put an angular app on the fron-end side

Applications can be downloaded from the hub docker:
- <a href="https://hub.docker.com/r/lukasztomalczyk/todolist/">https://hub.docker.com/r/lukasztomalczyk/todolist</a>
- `docker pull lukasztomalczyk/todolist`

<b><u>Used packages</u></b>
* Swashbuckle.AspNetCore 2.5.0<br>
* FluentNHibernate 2.1.2<br>
* Moq 4.8.3</br>
* NUnit 3.10.1</br>
* FluentAssertions" 5.4.0</br>

Use the swagger to view the API documentation
`http://localhost:[port]/swagger/`

- Available requests:<br>
* GET <br>
``
curl -X GET "http://localhost:5000/api/ToDoList/GetById/1" -H "accept: text/plain"
     http://localhost:5000/api/ToDoList/GetById/1
     ``
     <br><br>
* GET all resources <br>
``
curl -X GET "http://localhost:5000/api/ToDoList/GetAll" -H "accept: text/plain"
      http://localhost:5000/api/ToDoList/GetAll
``
<br>
* POST, PUT, DELETE<br>
<br><br>

* <b>Model entity</b>
````````
{
  "id": 0,
  "name": "string",
  "description": "string",
  "creationDate": "datetime",
  "dateOfCompletion": "datetime",
  "isDone": true
}
````````
<br>
<h1>I invite you to visit my blog</h1>
<a href="http://juniordevops.pl" target="_blank">www.JuniorDevOps.pl</a>
