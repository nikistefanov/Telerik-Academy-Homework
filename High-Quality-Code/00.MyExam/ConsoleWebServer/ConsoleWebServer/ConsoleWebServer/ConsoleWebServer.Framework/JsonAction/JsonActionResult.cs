namespace ConsoleWebServer.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using Newtonsoft.Json;    

    public class JsonActionResult : IActionResult
    {
        public readonly object Model;

        protected const string AccessControlOriginMessage = "Access-Control-Allow-Origin";
        protected const string CacheControlMessage = "Cache-Control";
        protected const string CacheControlMessageAdditionalInfoMessage = "private, max-age=0, no-cache";        

        public JsonActionResult(HttpRequest request, object method)
        {
            this.Model = method;
            this.Request = request;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        public HttpRequest Request { get; private set; }

        public List<KeyValuePair<string, string>> ResponseHeaders { get; private set; }

        public virtual HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.OK;
        }

        public string GetContent()
        {
            return JsonConvert.SerializeObject(this.Model);
        }

        public HttpResponse GetResponse()
        {
            var response = new HttpResponse(this.Request.ProtocolVersion, this.GetStatusCode(), this.GetContent());
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }  
}