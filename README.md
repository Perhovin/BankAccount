# Bank Account Manager

A simple console application written in C#. This is my educational project to practice Object-Oriented Programming (OOP) concepts, specifically focusing on class behavior, methods, and data types.

## Features

* **Account creation:** Uses a custom `BankAccount` class with a constructor to set the owner's name and initial balance securely.
* **Deposit funds:** Includes a `Deposit` method that accepts a specific amount to increase the account balance.
* **Withdraw funds:** Includes a `Withdraw` method to safely subtract money from the account.
* **Account summary:** A `ShowBalance` method that outputs the current state of the account (Owner and Balance) to the terminal.

## What I learned in this project

* How to define and use **methods** (behavior) to interact with class **fields** (state).
* How to pass **parameters** into methods (e.g., passing the transaction amount).
* How to use a constructor to initialize an object immediately upon creation.
* Why data types matter: resolving type mismatch errors by using `double` instead of `int` for financial calculations to prevent data loss.
* The basics of Encapsulation: keeping the mathematical logic for balance modifications safely inside the class, rather than scattering it across the main program.
