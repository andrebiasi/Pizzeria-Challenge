using System;

public class InvalidToppingException : Exception
{
    public InvalidToppingException(string message) : base(message) { }
}