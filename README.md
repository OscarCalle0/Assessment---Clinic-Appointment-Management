Appointment Management System API

This project is an API designed to manage appointments in a clinic. It includes features for user authentication, registration, password management, and appointment scheduling. The system ensures secure handling of sensitive data with JWT (JSON Web Tokens) for authentication and encrypted password storage.

## Features

- **User Registration**: Users can register with their email and password.
- **User Authentication**: Login functionality with JWT token generation.
- **Password Reset**: Users can request a password reset token sent via email.
- **Appointment Scheduling**: Appointment creation, update, and deletion.
- **JWT Authentication**: Secure authentication with token expiration.

## Technologies Used

- **Backend Framework**: .NET 8
- **Database**: MySQL
- **Authentication**: JWT (JSON Web Tokens)
- **Password Encryption**: bcrypt
- **Email**: SMTP for password reset emails (via Gmail)
- **ORM**: Entity Framework Core

## Setup Instructions

Follow these steps to set up the project on your local machine.

### Prerequisites

- .NET 8 SDK
- MySQL Server running locally or on a remote server
- A Gmail account for email functionality (optional for password reset emails)

### Clone the Repository

git clone https://github.com/yourusername/AppointmentManagementSystem.git
cd AppointmentManagementSystem
Configuration
Create a .env file in the root directory and configure the following environment variables:

DB_HOST=your-database-host
DB_PORT=3306
DB_DATABASE=your-database-name
DB_USERNAME=your-database-username
DB_PASSWORD=your-database-password
JWT_KEY=your-secret-jwt-key
JWT_ISSUER=your-jwt-issuer
JWT_AUDIENCE=your-jwt-audience
EMAIL=your-email@gmail.com
PASSWORD=your-email-password
Configure the SMTP settings in the project to use your Gmail account (for sending password reset emails). Modify the code where necessary in EmailService.cs.

Install Dependencies
Run the following command to restore the necessary NuGet packages:

dotnet restore
Database Setup
Run the following commands to create the database and apply migrations:

dotnet ef migrations add InitialCreate
dotnet ef database update
This will create the necessary tables in your MySQL database based on the entity models defined in the project.

Run the Application
To start the application locally, use the following command:

dotnet run
The API will be available at http://localhost:5000 by default.

Endpoints
Here are the main API endpoints you can use:

Authentication
POST /api/v1/auth/login: Log in and get a JWT token.
POST /api/v1/auth/register: Register a new user.
POST /api/v1/auth/forgot-password: Request a password reset email.
POST /api/v1/auth/reset-password: Reset the user's password with a valid token.
Appointment Management
POST /api/v1/appointments: Create a new appointment.
GET /api/v1/appointments/{id}: Retrieve details of an appointment.
PUT /api/v1/appointments/{id}: Update an appointment.
DELETE /api/v1/appointments/{id}: Delete an appointment.
Contributing
We welcome contributions to this project! If you'd like to contribute, please fork the repository, make your changes, and submit a pull request. Here are some areas where you could help:

Enhancing security features
Writing unit tests for the existing code
Improving the documentation
Adding new features or fixing bugs
License
This project is licensed under the MIT License - see the LICENSE file for details.
