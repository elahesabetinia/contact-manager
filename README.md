# Contact Manager

A console-based contact management app written in C#.

## Features
- Add contacts (name, phone, email) with duplicate-phone protection
- Search by name or phone
- Delete by phone number
- List all contacts

## Tech
- C# / .NET 10
- Object-oriented design: `Contact`, `ContactManager`, and a console UI layer

## How to run
    git clone https://github.com/elahesabetinia/contact-manager.git
    cd contact-manager/ContactManager
    dotnet run

## What I learned
- Separating data, logic, and UI into different classes
- Encapsulation with private fields and controlled public methods
- Building a menu-driven console app with input validation

## Possible improvements
- Save contacts to a JSON file
- Edit existing contacts
- Unit tests with xUnit
