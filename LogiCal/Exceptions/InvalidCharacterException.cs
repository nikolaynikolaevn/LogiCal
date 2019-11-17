using System;

namespace LogiCal
{
    public sealed class InvalidCharacterException : Exception
    {
        public InvalidCharacterException() : base("Syntax error: Invalid character.") { }
    }
}
