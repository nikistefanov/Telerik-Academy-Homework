﻿namespace ConsoleWebServer.Framework
{
    using System.Collections.Generic;

    public class JsonActionResultWithCors : JsonActionResult
    {
        public JsonActionResultWithCors(HttpRequest request, object model, string corsSettings)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(AccessControlOriginMessage, corsSettings));
        }
    }
}
