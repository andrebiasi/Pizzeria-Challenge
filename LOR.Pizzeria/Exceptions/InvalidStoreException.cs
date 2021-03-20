using System;

public class InvalidStoreException : Exception
{
    public InvalidStoreException(string message) : base(message) { }
}