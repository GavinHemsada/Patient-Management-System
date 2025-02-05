# Patient-Management-System

This is a desktop application for managing patient records in a healthcare setting. The application is built using C# and MySQL.

## Features
- Add, update, and delete patient records
- Search and filter patient records
- View patient history
- Generate reports

## Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/your-username/patient-management-system.git
    ```
2. Navigate to the project directory:
    ```bash
    cd patient-management-system
    ```
3. Open the project in Visual Studio.
4. Restore NuGet packages:
    ```bash
    Update-Package
    ```
5. Build the project:
    ```bash
    Build Solution
    ```

## Database Setup
1. Install MySQL server and MySQL Workbench.
2. Create a new database:
    ```sql
    CREATE DATABASE patient_management;
    ```
3. Import the database schema from the `database` directory:
    ```sql
    SOURCE path/to/patient_management.sql;
    ```

## Configuration
1. Update the database connection string in `App.config`:
    ```xml
    <connectionStrings>
        <add name="PatientManagementDB" connectionString="Server=localhost;Database=patient_management;Uid=root;Pwd=yourpassword;" providerName="MySql.Data.MySqlClient"/>
    </connectionStrings>
    ```

## Usage
1. Launch the application from Visual Studio.
2. Use the main menu to navigate through different features:
    - **Add Patient**: To add a new patient record.
    - **Search Patient**: To search for existing patient records.
    - **View History**: To view a patient's history.
    - **Reports**: To generate and view reports.

