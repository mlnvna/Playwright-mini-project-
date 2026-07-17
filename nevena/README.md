# TodoListMe Automation Tests

This project contains automated UI tests for the TodoListMe web application using Selenium WebDriver with NUnit in C#.

## Purpose
The goal of this project is to automate and validate the core user workflows of the application using a structured and maintainable test framework.

## Tech Stack
- C#
- .NET
- Selenium WebDriver
- NUnit

## Test Coverage
The automation suite focuses on the core functionality of the application:

- Creating a new task
- Completing an existing task

These tests represent the main user journey (task lifecycle).

## Architecture
The project is structured using the Page Object Model (POM) design pattern:

- Base: Shared base classes (BasePage)
- Config: Application configuration (BaseUrl)
- Pages: Page Object classes containing UI actions
- Tests: NUnit test cases

## How to Run
1. Open the solution in Visual Studio
2. Restore NuGet packages
3. Build the solution
4. Run tests using Test Explorer

## Notes
This project focuses on Tier 1 test cases as the highest priority based on business value and test automation strategy.