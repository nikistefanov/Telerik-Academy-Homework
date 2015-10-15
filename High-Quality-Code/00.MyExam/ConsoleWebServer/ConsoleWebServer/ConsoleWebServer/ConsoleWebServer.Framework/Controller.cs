﻿namespace ConsoleWebServer.Framework
{
    public abstract class Controller
    {
        protected Controller(HttpRq reqeust)
        {
            this.Request = reqeust;
        }

        public HttpRq Request { get; private set; }

        protected IActionResult Content(object model)
        {
            return new ContentActionResult(this.Request, model);
        }

        protected IActionResult Json(object model)
        {
            return new JsonActionResult(this.Request, model);
        }
    }
}
