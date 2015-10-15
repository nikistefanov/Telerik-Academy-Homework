namespace ConsoleWebServer.Application.Controllers
{
    using ConsoleWebServer.Framework;

    public abstract class Controller
    {
        protected Controller(HttpRequest reqeust)
        {
            this.Request = reqeust;
        }

        public HttpRequest Request { get; private set; }

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
