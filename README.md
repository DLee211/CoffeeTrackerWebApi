# Coffee Tracker Web API

This is a simple Web API project for tracking coffee consumption. It's built with .NET 8.0 and uses Entity Framework Core for data access.

## Features

- Get all coffees
- Get a coffee by ID
- Add a new coffee
- Update an existing coffee
- Delete a coffee

## Setup

1. Clone the repository
2. Navigate to the project directory
3. Run `dotnet restore` to restore the necessary packages
4. Run `dotnet run` to start the application

## API Endpoints

- `GET /coffee`: Get all coffees
- `GET /coffee/{id}`: Get a coffee by ID
- `POST /coffee`: Add a new coffee
- `PUT /coffee/{id}`: Update an existing coffee
- `DELETE /coffee/{id}`: Delete a coffee

## Models

### Coffee

- `Id`: The unique identifier of the coffee
- `DateConsumed`: The date the coffee was consumed
- `Cups`: The number of cups consumed
- `Notes`: Additional notes about the coffee
