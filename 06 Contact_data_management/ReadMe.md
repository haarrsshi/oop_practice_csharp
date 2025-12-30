# Contact Data Management – Task 06-02

## Description

This project implements a console application for managing contact data within a company.
The main focus of the task is the **design and implementation of an appropriate object-oriented class structure**.

The application does **not** include:

* a graphical user interface
* console input by users
* persistence using files or databases

Instead, the emphasis lies on:

* clean object-oriented design
* correct use of generalization and polymorphism
* clear separation of responsibilities

---

## Learning Objectives

This task is intended to reinforce and demonstrate understanding of:

* Object-Oriented Programming (OOP)
* Generalization
* Polymorphism
* Clean class design
* Data consistency

The use of generalization and polymorphism is **optional**, but their correct and meaningful application is encouraged.

---

## Functional Requirements

### Persons

The application must support the management of different persons.

For all persons, the following information must be stored:

* First name
* Last name
* Date of birth
* Gender

A distinction is made between:

* internal persons
* external persons

Additional data:

* Internal persons store department and date of entry
* External persons store the name of the associated company

---

### Contact Information

Each person can have multiple types of contact information:

* Email addresses
* Phone numbers

  * distinction between landline and mobile
* Postal addresses

  * consisting of street, postal code, and city

For each contact type:

* any number of entries can be stored
* one entry is marked as the primary contact
* the first entry is automatically set as primary
* the primary entry can be changed later

---

### Output

All information related to a person, including all contact information, must be printed to the console in a clear and structured manner.

---

### Optional Extension

As an optional extension, the application may support deleting contact information.

When implementing this feature, the following questions must be considered:

* How is the contact entry to be deleted identified?
* How is data consistency maintained after deletion?

---

## Technical Constraints

* Console application only
* No user input handling
* No GUI
* No external storage (files, databases, etc.)

---
## Notes

This project prioritizes **design quality over implementation complexity**.
Multiple valid solutions are possible, as long as the requirements are fulfilled and object-oriented principles are applied appropriately.
