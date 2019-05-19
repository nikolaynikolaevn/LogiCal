using System;

namespace LogiCal
{
    sealed class InvalidExpressionException : Exception
    {
        public InvalidExpressionException() : base("Syntax error: Invalid expression.") { }
    }
}
