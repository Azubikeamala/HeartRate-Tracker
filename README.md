#  HeartRate Tracker

HeartRate Tracker is a web-based ASP.NET Core MVC application designed to help users track and analyze their heart rate data. The goal is to provide a simple, user-friendly way to log heart rate entries, monitor changes over time, and gain insights into personal health trends.

## Project Structure

- Controllers – Handle app logic and routes
- Models – Define heart rate data structures
- Views – Razor pages for the frontend
- Migrations – Manage database schema using EF Core
- wwwroot – Static assets like JS, CSS, and images
- Program.cs and appsettings.json – App configuration and startup logic

## Getting Started

Follow these steps to run the project locally:

1. Clone the repository  
   git clone https://github.com/Azubikeamala/HeartRate-Tracker.git  
   cd HeartRate-Tracker

2. Open the solution in Visual Studio or VS Code

3. Update the database connection string in appsettings.json if needed

4. Apply migrations to set up the database  
   dotnet ef database update

5. Run the application  
   dotnet run

6. Open your browser and go to https://localhost:5001 or the port shown in your terminal

## Features

- Add, edit, and delete heart rate entries
- Calculate statistics like average, max, and min heart rate
- View history of heart rate logs
- Ready to extend with charts, user accounts, and export features

## Tech Stack

- ASP.NET Core MVC  
- C#  
- Entity Framework Core  
- Razor Views  
- SQL Server or SQLite (configurable)

## Ideas for Future Improvements

- Add user authentication  
- Show graphical trends with charts  
- Export data to CSV or PDF  
- Create mobile API endpoints  
- Add health alerts based on thresholds

## License

This project is licensed under the MIT License.

Thanks for checking it out!
