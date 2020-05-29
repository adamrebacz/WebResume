# WebResume
A web based resume site strictly dedicated for my achievements, work history, my motivations and other stuff that keeps me interesting.
## Requirements
* MVC .NET Core 3.1 Application in Visual Studio 2019 Comunity Edition
* [Azure Sit Link](https://about-me.azurewebsites.net)
* Entity Framework with SQL on Azure portal
* DevOps for CI/CD
* Admin logins - everybody who is a part of Admin Group in my Azure AD
* User login - everybody with Microsoft Account
* Beautiful yet simple WebDesign
* AJAX CRUD operations functionality
### Administrator Functionality
* CRUD operations to Site Section for example work history section.
* CRUD operations to Section Elements for example University i atended.
* CRUD operations to my Photo Portfolio - because i am an amature photographer i would like to show what makes me interesting.
* CRUD operations on Comments
### User Functionality
* Commenting on the entire site
* Commenting on specific photo
## Update 26.05.2020
### Azure
* Added basic code for MSAL Azure AD authentication for Admin account
## Update 28.05.2020
### EntityFramework
* Created Azure SQL Server
* Added EF to project and DB Context wirh connection string to Azure SQL Server
* Created Initial Migration and First Database Table [MS Doc link](https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli)
* Downloaded and the Azure Data Studio for Mac for DB Connections [Link](https://github.com/microsoft/azuredatastudio)
### Azure
* Created App Service [Site](https://about-me.azurewebsites.net)
* Created Azure App Registry
* Created Azure Resource group
### DevOps
* Created Continous Integration Build Pipline Visual Studio -> GitHub -> DevOps build PipeLine
