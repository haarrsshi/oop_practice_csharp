## 📌 Scenario

An online shop supports **different payment methods**.

---

## Requirements

### Base class (abstract)

Create an abstract class:

```
Payment
```

It has:

* `Amount` (decimal)
* constructor to set amount

It defines:

* abstract method `ProcessPayment()`
* virtual method `ShowDetails()`

---

### Payment types (Inheritance + Polymorphism)

#### CreditCardPayment

* extra property: `CardNumber`
* overrides `ProcessPayment()`
* overrides `ShowDetails()` (also prints card info)

#### BankTransferPayment

* extra property: `Iban`
* overrides `ProcessPayment()`
* overrides `ShowDetails()` (also prints IBAN)

---

### 3Program behavior (MANDATORY)

In `Main`:

* Create a `List<Payment>`
* Add **at least 2 different payment objects**
* Loop over the list and:

  * call `ShowDetails()`
  * call `ProcessPayment()`
