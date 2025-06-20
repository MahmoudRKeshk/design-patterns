# Design Patterns

This repository demonstrates classic software design patterns in C#. Each pattern is implemented in a dedicated folder and can be run/tested individually. The intent is to provide clear, practical examples for learning and interview preparation.

---

## 1. Creational Patterns

| Pattern         | Definition & Intent                                                                 |
|-----------------|------------------------------------------------------------------------------------|
| **Builder**     | Separates the construction of a complex object from its representation.            |
| **Factory Method** | Defines an interface for creating an object, but lets subclasses alter the type. |
| **Prototype**   | Creates new objects by copying an existing object, known as the prototype.         |
| **Singleton**   | Ensures a class has only one instance and provides a global point of access.       |

---

## 2. Structural Patterns

| Pattern         | Definition & Intent                                                                 |
|-----------------|------------------------------------------------------------------------------------|
| **Adapter**     | Allows incompatible interfaces to work together by wrapping an existing class.      |
| **Bridge**      | Decouples an abstraction from its implementation so they can vary independently.    |
| **Composite**   | Composes objects into tree structures to represent part-whole hierarchies.         |
| **Decorator**   | Adds new behavior to objects dynamically by placing them inside special wrapper objects. |
| **Facade**      | Provides a simplified interface to a complex subsystem.                            |
| **Flyweight**   | Reduces memory usage by sharing as much data as possible with similar objects.      |
| **Proxy**       | Provides a surrogate or placeholder for another object to control access to it.     |

---

## 3. Behavioral Patterns

| Pattern                | Definition & Intent                                                          |
|------------------------|-----------------------------------------------------------------------------|
| **Chain of Responsibility (CoR)** | Passes requests along a chain of handlers until one handles it.         |
| **Command**            | Encapsulates a request as an object, allowing parameterization and queuing.  |
| **Mediator**           | Defines an object that coordinates communication between other objects.       |
| **Memento**            | Captures and restores an object's internal state without violating encapsulation. |
| **Observer**           | Defines a dependency so that when one object changes state, all dependents are notified. |
| **State**              | Allows an object to alter its behavior when its internal state changes.       |
| **Strategy**           | Defines a family of algorithms, encapsulates each, and makes them interchangeable. |
| **Template Method**    | Defines the skeleton of an algorithm, deferring some steps to subclasses.     |
| **Visitor**            | Separates an algorithm from the objects on which it operates.                 |

---

## Usage

- Each pattern is implemented in its respective folder.
- Run the project to see console outputs demonstrating each pattern in action.
- Explore the `Testing/` directory for usage examples.

---
