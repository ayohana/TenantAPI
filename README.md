# [Tenant API](https://github.com/ayohana/TenantAPI.git/)

#### C# Build an API Exercise for [Epicodus](https://www.epicodus.com/), 04.03.2020 v. 2.0

#### By [**Adela Darmansyah**](https://ayohana.github.io/portfolio/)

## Description

**A service API that allows apartment managers to keep track of their tenants' contact information.**

## User Stories

* As a manager, I want to be able to view (`GET`) and add (`POST`) contact information of tenants.
* As a manager, I want to view (`GET`) a list of contact information by apartment name, apartment number or by a tenant's last name.
* As a manager, I want to be able to update (`PUT`) and remove (`DELETE`) tenants.
* As a developer, I want the application to still be able to display query search results when a user inputs only part of an apartment name. For instance, search query of apartment name `"baker"` will display tenants listed under `"Baker Apartments"`.
* As a developer, I want to add a feature of API versioning so that I can keep different versions when I upgrade the application.

## Setup/Installation Requirements

* Download [.NET Core](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) (Mac/Windows OS) - _FREE!_
* Download [MySQL](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) (Mac/Windows OS) - _FREE!_
* Download [Postman](https://www.postman.com/downloads/) (Mac/Windows OS) - _FREE!_
* Clone this [repository](https://github.com/ayohana/TenantAPI.git/)
* Run the application.
  * Navigate into the `TenantAPI` directory `$ cd Desktop/TenantAPI/`
    * Enter the command `dotnet restore` to gather tools and dependencies for the application.
    * Enter the command `dotnet build` to build the project using its dependencies.
    * Enter the command `dotnet ef database update` to create a new, empty database. 
    * Enter `dotnet run` to run the application.
    * Enter URL `http://localhost:5000/api/tenants` in Postman using one of the HTTP Methods [below](#HTTP-Methods-and-Routes).

## Version History

<details>
  <summary>2.0</summary>

  | Features | Input | Output |
  | :----------- | :---- | :----- |
  | Improved `GET` action. <br> When a user enters an incomplete apartment name, the application will still return results based on the input. | `http://localhost:5000/api/tenants/?apartmentname=b` | List of tenants with apartment names consisting a `"b"`  |
  | Set default application to run on version 2.0 | N/A | N/A  |

</details>

<details>
  <summary>1.0</summary>

  | Features |
  | :----------- |
  | Basic working functionalities listed [below](#HTTP-Methods-and-Routes). |

</details>    

## HTTP Methods and Routes

| HTTP Method | HTTP Route | Input | Output |
| :---------- | :--------- | :---- | :----- |
| GET | /api/tenants | N/A | View a list of all tenants |
| GET | /api/tenants?apartmentname=`name+of+apt`&apartmentnumber=`apt#`&lastname=`last+name` | Insert search query values to HTTP route  | View a list of tenants by apartment name, apartment number and/or last name. |
| POST | /api/tenants | JSON body | Create a new tenant |
| PUT | /api/tenants/{id} | JSON body | Edit information on a tenant |
| DELETE | /api/tenants/{id} | N/A | Remove a tenant |

## Screenshots/API Endpoints

<!-- TODO -->





## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: adela.yohana@gmail.com.

## Technologies Used

* C#
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/) (Windows OS)
* [MySQL](https://dev.mysql.com/downloads/file/?id=484919) (Windows OS)
* [EF Core](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)
* [Postman](https://www.postman.com/downloads/)

### License

This C# console application is licensed under the MIT license.

Copyright (c) 2020 **Adela Darmansyah**