namespace ConsoleWebServer.Framework
{
    /// <summary>
    /// Represents the provider who can complete the request
    /// </summary>
    /// 
    public interface IResponseProvider
    {
        /// <summary>
        /// Processes the request
        /// </summary>
        /// <param name="requestAsString">The request to be processes</param>
        /// <returns>The request</returns>
        HttpResponse GetResponse(string requestAsString);
    }
}