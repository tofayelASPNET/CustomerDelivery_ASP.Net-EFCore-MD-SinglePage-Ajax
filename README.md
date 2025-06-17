🧾 Project: Core Master-Details - Single Page (Code First + AJAX)
This ASP.NET Core MVC project demonstrates a Master-Details data entry and management system using Entity Framework Core (Code First) approach, implemented in a single-page layout with seamless AJAX operations using JavaScript.

✨ Key Features
🔄 Single-Page CRUD Interface for Customer (Master) and associated DeliveryAddress (Details)

⚙️ Entity Framework Core (Code First) for data modeling and database generation

🚀 AJAX-based interaction to perform Create, Read, Update, Delete (CRUD) without full page reloads

📅 Formatted data handling using attributes like [DisplayFormat] and [Column(TypeName = "date")]

📸 Optional photo handling for customers

📦 Bootstrap-based UI for responsive design

🧩 Master-Details Structure
Master: Customer
Represents core customer information.

Fields:

CustomerId (Primary Key)

CustomerCode (optional)

Name (required, max 50 chars)

Address

BusinessStart (Date, formatted)

CustomerType

Phone (required)

Email

CreditDetails (money type)

Photo (optional)

DeliveryAddresses (Navigation Property)

Details: DeliveryAddress
Linked to a specific Customer, holds delivery-specific contacts.

Fields:

DeliveryAddressId (Primary Key)

CustomerId (Foreign Key)

ContactPerson (required, max 60 chars)

Phone (required)

Address (required)

Customer (Navigation Property)

🛠️ Technologies Used
ASP.NET Core MVC

Entity Framework Core (Code First)

SQL Server

JavaScript / AJAX

Bootstrap 5

Data Annotations for validation and formatting

🔄 Functional Flow
Customer Entry – Create a new customer with optional photo upload.

AJAX-Based Detail Add/Edit/Delete – Dynamically manage delivery addresses using AJAX.

Form Validation – Server-side and client-side validation via Data Annotations.

Seamless UI Updates – Without page reload, thanks to JavaScript integration.

