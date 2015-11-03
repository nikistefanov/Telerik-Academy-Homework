namespace ConsoleWebServer.Framework
{
    using System.Collections.Generic;

    public class ContentActionResultWithCorsWithoutCaching : ContentActionResult
    {
        public ContentActionResultWithCorsWithoutCaching(HttpRequest request, object model, string corsSettings) : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(AccessAllowOriginMessage, corsSettings));
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(CacheControlMessage, ChacheControlAdditionalInfoMessage));
        }
    }
}
