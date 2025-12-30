# Payment System (OOP Practice)

This project is a console application created to practice object-oriented programming concepts in C#.

The task focuses on designing a clean class structure using inheritance and polymorphism to handle different payment methods in a uniform way.

---

## Task Description

An online shop supports different payment methods.

All payment methods share some common information and behavior, but each payment type processes the payment differently.

The system should:
- support multiple payment types
- store them together using a common base type
- execute payment logic using polymorphism

---

## Implemented Requirements

- A base abstract class is used to represent a generic payment.
- The base class stores the payment amount and defines common behavior.
- Different payment types extend the base class and implement their own logic.

Payment types implemented:
- Credit card payment
- Bank transfer payment

Each payment type:
- overrides the payment processing method
- displays its own details when requested

---

## Program Behavior

When the program runs:
- multiple payment objects are created
- all payments are stored in a list of the base type
- each payment is processed using a loop
- details and processing logic are executed polymorphically

---

## OOP Concepts Practiced

- Abstract classes
- Inheritance
- Method overriding
- Polymorphism using a base-type list
- Separation of logic and output

---

## Notes

This project does not include user input, a graphical interface, or real payment processing.
All output is printed to the console for demonstration purposes.
