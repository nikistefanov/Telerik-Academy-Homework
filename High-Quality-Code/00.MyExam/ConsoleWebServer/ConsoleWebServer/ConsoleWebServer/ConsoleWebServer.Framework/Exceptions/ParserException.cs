﻿namespace ConsoleWebServer.Framework.Exceptions
{
    using System;

    public class ParserException : Exception
    {
        public ParserException(string message, ActionDescriptor request = null)
            : base(message)
        {
        }
    }
}
