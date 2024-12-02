using System;
using System.Collections.Generic;

/// <summary>
/// Interface for components that can be decorated.
/// </summary>
public interface IComponent
{
    void Operation();
}

/// <summary>
/// Concrete implementation of the component interface.
/// </summary>
public class ConcreteComponent : IComponent
{
    /// <summary>
    /// Performs a basic operation.
    /// </summary>
    public void Operation()
    {
        Console.WriteLine("ConcreteComponent: Basic operation.");
    }
}

/// <summary>
/// Abstract decorator class that implements the IComponent interface.
/// </summary>
public abstract class Decorator : IComponent
{
    protected IComponent _component;

    /// <summary>
    /// Initializes a new instance of the decorator class with a component to decorate.
    /// </summary>
    /// <param name="component">The component to decorate.</param>
    public Decorator(IComponent component)
    {
        _component = component;
    }

    /// <summary>
    /// Performs the operation by delegating to the wrapped component.
    /// </summary>
    public virtual void Operation()
    {
        _component.Operation();
    }
}

/// <summary>
/// Concrete decorator that adds additional behavior before calling the wrapped operation.
/// </summary>
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) : base(component) { }

    /// <summary>
    /// Adds behavior before the wrapped operation.
    /// </summary>
    public override void Operation()
    {
        Console.WriteLine("ConcreteDecoratorA: Adding behavior before operation.");
        base.Operation();
    }
}

/// <summary>
/// Another concrete decorator that adds behavior after the wrapped operation.
/// </summary>
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) : base(component) { }

    /// <summary>
    /// Adds behavior after the wrapped operation.
    /// </summary>
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorB: Adding behavior after operation.");
    }
}

/// <summary>
/// Client code for demonstrating the decorator pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    public static void Main()
    {
        // Create a ConcreteComponent instance.
        IComponent component = new ConcreteComponent();

        // Decorate the component with ConcreteDecoratorA.
        IComponent decoratorA = new ConcreteDecoratorA(component);

        // Decorate with ConcreteDecoratorB to add behavior after the operation.
        IComponent decoratorB = new ConcreteDecoratorB(decoratorA);

        // Execute the operation, which includes the behavior of all decorators.
        Console.WriteLine("Client: Executing operation on the decorated component.");
        decoratorB.Operation();
    }
}
