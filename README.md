# Design Patterns - Decorator

This repository showcases an implementation of the Decorator design pattern in C#. The code demonstrates how to dynamically add behavior to an object by wrapping it with decorator classes, enabling enhanced functionality without modifying the original component. This pattern is useful for adding new features to objects in a flexible and reusable way.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Decorator design pattern is a structural pattern that allows behavior to be added to individual objects dynamically. It provides an alternative to subclassing for extending functionality. The pattern works by creating a set of decorator classes that are used to wrap concrete components.

## Implementation Overview
This repository provides a C# implementation of the Decorator design pattern. Key components of the code include:

- **IComponent Interface**: Defines the operation method that both the concrete component and decorators will implement.
- **ConcreteComponent Class**: Implements the `IComponent` interface and provides a basic operation.
- **Decorator Class**: An abstract class that implements the `IComponent` interface and holds a reference to an `IComponent` object to delegate operations.
- **ConcreteDecoratorA and ConcreteDecoratorB Classes**: These classes add new behaviors before and after calling the base operation.
- **Program Class**: Demonstrates how to use the `Decorator` pattern to wrap and extend the functionality of a `ConcreteComponent`.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Decorator.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Decorator
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Decorator pattern in action.
3. Modify the `ConcreteComponent` class or the `Main()` method to customize the demonstration or add other decorators.

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

