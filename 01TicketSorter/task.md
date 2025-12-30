## Scenario: **Ticket System**

A company wants to manage **support tickets**.

---

## Requirements

### Ticket (Base Concept)

Each ticket has:

* an **ID**
* a **title**
* a **description**
* a **status** (Open / In Progress / Closed)

Each ticket can:

* be **opened**
* be **closed**
* display its **details on the console**

---

### Ticket Types (Inheritance REQUIRED)

There are **two types of tickets**:

#### InternalTicket

* created by employees
* has an extra property: **Department**

#### ExternalTicket

* created by customers
* has an extra property: **CustomerEmail**

---

### Polymorphism (IMPORTANT)

Each ticket type should display its details **slightly differently**:

* InternalTicket also shows the department
* ExternalTicket also shows the customer email

👉 You must use **method overriding** for this
(no if-else based on type)

---

### Program Behavior

In `Main`:

* Create **at least 1 InternalTicket and 1 ExternalTicket**
* Store them in a **list of base type**
* Loop over the list and display ticket details

This is where polymorphism must **actually work**.

## What the examiner wants to see

* Clean base class
* Correct inheritance
* Proper use of `virtual` / `override`
* No duplicated code
* Clear console output

Not fancy. Not huge. Just **correct OOP thinking**.

---