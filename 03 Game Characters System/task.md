
## Scenario

A simple game has **different types of characters**.

---

## Requirements

### Base class (abstract)

Create an abstract class:

```
Character
```

It has:

* `Name` (string)
* `Health` (int)

Constructor:

* sets name and health

Methods:

* `TakeDamage(int amount)` → reduces health
* `IsAlive()` → returns true if health > 0
* abstract method `Attack()`

---

### Character types (Inheritance + Override)

#### Warrior

* extra property: `Strength`
* `Attack()` prints damage based on strength

#### Mage

* extra property: `Mana`
* `Attack()` prints damage based on mana

Each `Attack()` implementation must be **different**.

---

### Polymorphism (MANDATORY)

In `Main`:

* Create a `List<Character>`
* Add **at least one Warrior and one Mage**
* Loop over the list and:

  * call `Attack()`
  * call `TakeDamage(20)`
  * print whether the character is alive