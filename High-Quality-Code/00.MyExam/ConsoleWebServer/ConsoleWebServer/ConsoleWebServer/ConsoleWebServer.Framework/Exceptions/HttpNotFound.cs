namespace ConsoleWebServer.Framework
{
    using System;

    public class HttpNotFound : Exception
    {
        public HttpNotFound(string message)
            : base(message)
        {
        }
    }
}