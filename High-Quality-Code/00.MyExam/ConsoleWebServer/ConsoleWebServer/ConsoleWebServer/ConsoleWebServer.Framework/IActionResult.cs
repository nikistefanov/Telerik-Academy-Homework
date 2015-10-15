namespace ConsoleWebServer.Framework
{
    /// <summary>
    /// Represent the provider who can complete the needed action
    /// </summary>
    /// 
    public interface IActionResult
    {
        /// <summary>
        /// Processes the action
        /// </summary>
        /// <returns>The completed action</returns>
        HttpResponse GetResponse();
    }
}