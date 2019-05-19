using System;

namespace LogiCal
{
    sealed class LeftBracketExpectedException : Exception
    {
        public LeftBracketExpectedException() : base("Syntax error: Expected opening bracket.") { }
    }
}
