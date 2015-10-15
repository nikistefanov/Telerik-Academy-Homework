namespace ConsoleWebServer.Application.Controllers
{
    using ConsoleWebServer.Framework;

    public class HomeController : Controller
    {
        private const string IndexContent = "Home page :)";
        private const string LivePageContent = "Live page with no caching";
        private const string LivePageForAjaxContent = "Live page with no caching and CORS";
        private const string Symbols = "*";

        public HomeController(HttpRequest request) 
            : base(request)
        {
        }

        public IActionResult Index(string param)
        {
            return this.Content(IndexContent);
        }

        public IActionResult LivePage(string param)
        {
            return new ContentActionResultWithoutCaching(this.Request, LivePageContent);
        }
        
        public IActionResult LivePageForAjax(string param)
        {
            return new ContentActionResultWithCorsWithoutCaching(this.Request, LivePageForAjaxContent, Symbols);
        }

        public IActionResult Forum(string param)
        {
            return this.Content(string.Empty);
        }
    }
}
