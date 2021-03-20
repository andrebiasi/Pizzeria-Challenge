using System;

public class InvalidPizzaTypeException : Exception
{
    public InvalidPizzaTypeException(string message) : base(message) { }
}