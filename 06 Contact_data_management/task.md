# Task 06-02: Contact Data Management

The concepts and language constructs of **generalization and polymorphism** are fundamentally known.
By working on this task, the understanding of these concepts should be reviewed and reinforced.
It therefore makes sense to deliberately think in advance about **where and how** these two core concepts of object-oriented programming can be applied **sensibly and effectively**.

Generalization and polymorphism are optional.

Many applications could be implemented without generalization and polymorphism. However, this almost never makes sense. Conversely, an inheritance hierarchy can also be made unnecessarily complex.

Use this task explicitly to **examine and demonstrate** your understanding of these two concepts through an example.

---

## Assignment

Create an application that simplifies the management of contact data for a company.
The focus of this application lies on the **design and implementation of an appropriate class design**.

There is **no requirement** to implement actual input of contact data by users
(no GUI, no console input).

When implementing this task as a new C# project, observe the following requirements:

---

### Persons

For all persons, the following information must be recorded:

* First name
* Last name
* Date of birth
* Gender

A distinction is made between **internal** and **external** persons.

For **internal persons**, the following additional information must be recorded:

* Department
* Date of entry

For **external persons**, the following additional information must be recorded:

* Company name

---

### Contact Information

For all persons, **different types of contact information** must be recorded:

* Email address
* Telephone number

  * distinction between landline and mobile phone
* Postal address

  * consisting of street, postal code, and city

---

### Multiple Contact Entries

For each person, it must be possible to record **any number of entries** for each of the three types of contact information:

* e.g. 2 email addresses
* 3 phone numbers
* 0 postal addresses

For each type of contact information, **one entry must be marked as the primary contact**
(e.g. one main phone number out of three phone numbers).

* The **first entry** of each contact information type is automatically set as the primary contact.
* The primary contact can be changed at a later time.

---

### Output

All information of any person (including all contact information) must be **printed clearly and neatly** to the console.

---

### Optional Additional Task

Contact information of a person can be deleted.

* How can it be defined **which** contact information should be deleted?
* What must happen when a contact information is deleted in order to keep the overall data **consistent**?

---

## Working Method

Students are free to implement the application either individually or in pairs.

During the working phase, the teacher will regularly interrupt the work with inputs and possible solutions.
In particular, before the individual work phase begins, a possible concept will be developed in plenary, discussing which aspects of the implementation are particularly suitable for applying generalization and polymorphism.

---

## Time

Approximately **two full lessons** are available for working on this task during class time (including teacher inputs).

---

## Documentation

Create a new console project for this task (`dotnet new console`).
The intermediate steps presented by the teacher during inputs will be provided in a separate repository.

---

## Evaluation

During the work process, possible implementations of different requirements will be discussed in plenary.
The teacher will either present their own possible implementation or discuss different student approaches with the class as examples.

