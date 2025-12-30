# PRACTICAL OOP TASK — **Learning Platform System**

A digital learning platform is used by different people to access educational content.
The platform must support **different types of users**, **different types of learning content**, and **tracking of progress**.

Each user can interact with the platform in their own way, depending on their role and the type of content they are accessing.

---

## General Description

The platform manages users who can access various learning resources.
Some users create content, while others only consume it.
Learning resources may differ in structure and in how progress is measured.

The system must allow the platform to:

* store users and learning content together
* handle interactions in a uniform way
* still allow different behavior depending on the actual user or content type

The focus of this task is **object-oriented design**, not UI or input handling.

---

## Users

The platform supports multiple kinds of users.

All users:

* have identifying information
* can access learning content
* can have progress associated with learning content

Some users:

* are allowed to create new learning content
* can review or manage content created by others

Other users:

* are only allowed to consume content
* cannot modify or create content

Different user types may behave differently when interacting with learning content.

---

## Learning Content

The platform offers different kinds of learning content.

All learning content:

* has a title
* can be accessed by users
* supports progress tracking

However:

* some content measures progress based on completion percentage
* other content measures progress based on completed units (e.g. lessons, chapters, or tasks)

Each type of content must define **how progress is calculated and displayed**.

---

## Interaction & Polymorphism

The platform must be able to:

* store different users together
* store different content types together
* allow users to interact with content without knowing the exact type in advance

When a user accesses content:

* the system should update progress appropriately
* the behavior should depend on the actual type of user and content involved

Type checks (`if`, `switch`, casting) based on concrete classes should be avoided.

---

## Program Behaviour

When the application runs:

* several users of different kinds are created
* several learning content items of different kinds are created
* users interact with the content
* progress information is displayed clearly on the console

The program should demonstrate:

* clean object-oriented structure
* reuse of shared behavior
* correct use of polymorphism
* meaningful separation of responsibility

---

## Constraints

* No GUI
* No user input
* No databases or files
* Console output only

The task is **not** about building a full system, but about **designing an appropriate class structure** and showing correct interactions.

---


