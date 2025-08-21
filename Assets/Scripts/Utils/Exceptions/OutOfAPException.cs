using System;

public class OutOfAPException : Exception
{
    public OutOfAPException() { }

    public OutOfAPException(string message) 
        : base(message) { }

    public OutOfAPException(string message, Exception inner) 
        : base(message, inner) { }
}