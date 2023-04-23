# Echo Server Side
In the second part, we created the server-side of our messenger using ASP.NET technology and developed a RESTful API. We worked with models and controllers to manage the API and added services and repositories to make our project scalable and maintain encapsulation.

We used a database to store information about our users and implemented jwt-tokens to allow users to stay logged in to our app for a certain amount of time. Additionally, we utilized Microsoft's SignalR technology to enable real-time communication within our app

## Instructions:
1. After cloning the repository on your computer, make sure you install the following packages: Entity Framework Core, Entity Framework Tools, JwtBearer.

2. We used a SQL database for the Feedback APP and a static database for the API. In the ContextData.cs file located in the Repository folder, you can find the static database that we created, which contains some pre-existing users. If you make changes to the server's URL, make sure to also change the URL in the ContextData.cs file for the users (currently set to localhost:7099).

3. To use the React app, you need to simultaneously run both the 'EchoAPI' and 'WebAplication3' (the feedbacks app) applications. You can find more information in the README of the Echo React repository.


