using System;

namespace LogiCal
{
    sealed class InvalidCharacterException : Exception
    {
        public InvalidCharacterException() : base("Syntax error: Invalid character.") { }
    }
}
