# Talks

## Tech stack

- React: Application based on the [quickstart](https://auth0.com/docs/quickstart/spa/react/01-login) that logins and contains a simple implementation calls to Auth0 as authentication provider and requests to API server to conventions management 
- ASP.NET Core: Application based on the [Clean Architecture template](https://github.com/jasontaylordev/CleanArchitecture)

## How to use it

- Clone the repository

### API

- Open the Talks.sln solution
- Choose as project of execution the `docker-compose.dcproj` project
- Run the application

### SPA

- CD into the `frontend` folder
- Run `npm install`
- Run `npm start`

### C4 Diagrams

The following are the architectural diagramas that describes the implementation

## Context Diagram
![C4 Context Diagram](https://user-images.githubusercontent.com/56080653/123594263-c825ad00-d7ef-11eb-9143-cd7852ec720e.png)

## Containers Diagram
![C4 Containers Diagram](https://user-images.githubusercontent.com/56080653/123594289-ceb42480-d7ef-11eb-8b54-40a98ebd98cf.png)

## Components Diagram
![C4 Components Diagram](https://user-images.githubusercontent.com/56080653/123594279-cbb93400-d7ef-11eb-95fe-1a4cd8072021.png)

### Design decisions
- Separation of concerns is the main goal of using this Clean Architecture template
- The API project is using CQRS pattern to split the CRUD logic into Read queries and CUD commands,
- The API project is also using the mediator pattern to decouple the usage of the queries and commands

### Limitations
- The GitHub repository contains a raw implementation of a end-to-end application built in React 16.8.6 and ASP.NET Core (.NET 5) with C# language.
- The SPA application is not fully finished and is not discoverable via links in the UI interface
- The SPA application has a raw implementation of HTTP request to the API and it lacks the core functionality
- The docker componse can't mount the frontend application

### Improvements
- Move to Azure Key Vault the usage of credentials or any sensitive data
- Asking for user consents when they log in to be contacted by using email
- Creation of React components to extract common logic
- UI unit tests
- API Integration tests
- API versioning
- API Rate limit calls

