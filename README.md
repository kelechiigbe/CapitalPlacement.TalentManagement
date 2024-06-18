# Capital Placement App
   - This is a part of a feature application that allows a user to achieve the following scenario:
     1. Create application form for a program
     2. Allow user to apply and store the information
  
        
  ## To clone the repository and run the .NET 8 App, follow these steps:
  
   - Clone the repository using Git:
     ### git clone https://github.com/kelechiigbe/CapitalPlacement.TalentManagement.git

   - Navigate to the project directory:
     ### cd CapitalPlacement.TalentManagement

   - Update the appsettings.json file with your Cosmo db connection string.

   - Restore dependencies and build the project by runing:
     ### dotnet restore 
     ### dotnet build

   - Run the application:
     ### dotnet run


  ## Technologies used and design decisions
   - I made use of clean architecture as it helps in reducing coupling between components, making the codebase more flexible and resilient to   changes. It also enables better code organization, leading to improved code quality and easier debugging. Overall, clean architecture enhances the long-term sustainability and evolution of software projects by providing a solid foundation for growth and adaptation to future requirements.

   - I made use of FluentValiadions api so as to separate validation concerns from my business logic, promoting a cleaner and more organized codebase.

   - For my data access, I made use of Entity Framework Core for the following reasons
     1. Productivity
     2. Cross-Platform Support
     3. LINQ Integration
     4. Migration Support
     5. Performance Optimization: Entity Framework Core includes features like query caching and lazy loading, which can help optimize performance.

  ## Testing
   - After running the application you can navigate to [BaseUrl/swagger/index.html] to test the endpoints.

I hope you enjoy reading the source code as I enjoyed coding it. 
 







