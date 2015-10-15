namespace ConsoleWebServer.Framework
{
    using ConsoleWebServer.Framework;

    public class NewActionInvoker
    {
        // TODO: middleman?
        public IActionResult InvokeAction(Controller controller, ActionDescriptor actionDescriptor)
        {
            var className = HttpNotFound.ClassName;
            return new ActionInvoker().InvokeAction(controller, actionDescriptor);
        }
    }
}