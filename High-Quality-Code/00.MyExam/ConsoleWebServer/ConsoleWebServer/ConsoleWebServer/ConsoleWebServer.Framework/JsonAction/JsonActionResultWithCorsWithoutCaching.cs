namespace ConsoleWebServer.Framework
{
    using System.Collections.Generic;

    public class JsonActionResultWithCorsWithoutCaching : JsonActionResult
    {
        public JsonActionResultWithCorsWithoutCaching(HttpRequest request, object model, string corsSettings)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(AccessControlOriginMessage, corsSettings));
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(CacheControlMessage, CacheControlMessageAdditionalInfoMessage));
        }
    }
}
