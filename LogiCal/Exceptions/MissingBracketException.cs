using System;

namespace LogiCal
{
    sealed class MissingBracketException : Exception
    {
        public MissingBracketException() : base("Syntax error: Missing opening or closing bracket.") { }
    }
}
