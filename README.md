# Expense Tracker App

A lightweight ASP.NET MVC application for tracking and categorizing expenses.

## Features
- Add, view, and delete expenses  
- Categorize by enum (Food, Transportation, Utilities, etc.)  
- Calculates total expenses dynamically  
- Unit tests with MSTest and **in-memory EF Core**  (**Locally coded, to be added to GitHub repository**)

##  Tech Stack
- ASP.NET MVC  
- C#  
- Entity Framework Core  
- MSTest  
- Bootstrap  

## TO-DO:
- Bootstrap for more fancy layout
- Add pie charts and/or other visualizations to show how much each expense type is contributing.
- Integrate Unit Tests from local repository into GitHub repository.
- Options for what currency type
- Instructions for how to publish it
- A search bar for specific types of expenses
- Filtering for each column
- Reorder columns to put "Description at the front", and have an optional "Misc info" column at the end.


# Overview
<img width="725" height="403" alt="image" src="https://github.com/user-attachments/assets/ab0b9aec-b79e-4658-b4ca-f435adfa1b1f" />

The **Total Spent** counter uses the dynamic ViewBag controller's "Total" property to sum up all costs on the list. Will be updated eventually to be relevant for which items are currently listed.

Click "Create New" to access the expenses creation page.
<img width="296" height="445" alt="image" src="https://github.com/user-attachments/assets/259ecaae-c144-42be-bba6-e653c751c4b4" />
Here, you can choose between an enumerated set of cateogries, the amount of money (currently in USD, no symbols allowed), date of expense, and exactly what the expense is (need to reorder to the second on the list.)
This is what the list of categories currently set up are:
<img width="254" height="365" alt="image" src="https://github.com/user-attachments/assets/fa7a3c08-d551-44e2-aae3-d9e199144cf4" />

Click "Create" once you're done with your fields to add a new item to the list:
<img width="315" height="407" alt="image" src="https://github.com/user-attachments/assets/7c505480-72ec-4e9a-a1da-e045e18283ff" />

<img width="755" height="482" alt="image" src="https://github.com/user-attachments/assets/d115da7f-38a0-442c-a7ff-96b6bc86971e" />
As shown in the above screenshot, the new item has arrived on the list, contributing to the overall cost.

Each expense row has options to remove, edit information, or see details on the expense. The total cost of what's listed will change depending on these edits.
- These will run to a local DB using CRUD-type methods (create, read, update, delete) as part of the app's MVC structure.
