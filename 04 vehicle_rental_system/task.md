## Scenario

A company rents out different **vehicles**.

---

## REQUIREMENTS

### Base class (abstract)

Create an abstract class:

```
Vehicle
```

It has:

* `Brand` (string)
* `IsRented` (bool)

Constructor:

* sets brand
* sets `IsRented = false`

Methods:

* `Rent()` → marks vehicle as rented
* `Return()` → marks vehicle as available
* abstract method `CalculateRentalPrice(int days)`

---

### Vehicle types (inheritance)

#### Car

* extra property: `DailyRate`
* rental price = `DailyRate * days`

#### Bike

* extra property: `HourlyRate`
* rental price = `HourlyRate * days * 24`

(each class implements `CalculateRentalPrice` differently)

---

### Polymorphism (MANDATORY)

In `Main`:

* Create a `List<Vehicle>`
* Add **at least one Car and one Bike**
* Loop over the list:

  * rent each vehicle
  * calculate rental price for X days
  * print the price
  * return the vehicle