namespace ConsoleWebServer.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Text;

    public class HttpResponse
    {
        private const string ContentTypeInformation = "text/plain; charset=utf-8";
        private const string ServerName = "ConsoleWebServer";
        private const string ProtocolPrefixMessage = "HTTP/";
        private const string ServerAddressHeader = "Server";
        private const string ContentLenghtAddressHeader = "Content-Length";
        private const string ContentTypeAddressHeader = "Content-Type";

        private string serverEngineName;

        public HttpResponse(
            Version httpVersion,
            HttpStatusCode statusCode,
            string body,
            string contentType = ContentTypeInformation)
        {
            this.serverEngineName = ServerName;
            this.ProtocolVersion = Version.Parse(httpVersion.ToString().ToLower().Replace(ProtocolPrefixMessage.ToLower(), string.Empty));
            this.Headers = new SortedDictionary<string, ICollection<string>>();
            this.Body = body;
            this.StatusCode = statusCode;
            this.AddHeader(ServerAddressHeader, this.serverEngineName);
            this.AddHeader(ContentLenghtAddressHeader, body.Length.ToString());
            this.AddHeader(ContentTypeAddressHeader, contentType);
        }

        public Version ProtocolVersion { get; protected set; }

        public IDictionary<string, ICollection<string>> Headers { get; protected set; }

        public HttpStatusCode StatusCode { get; private set; }

        public string Body { get; private set; }

        public string StatusCodeAsString
        {
            get
            {
                return this.StatusCode.ToString();
            }
        }

        public void AddHeader(string name, string value)
        {
            if (!this.Headers.ContainsKey(name))
            {
                this.Headers.Add(name, new HashSet<string>());
            }

            this.Headers[name].Add(value);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(
                string.Format(
                    "{0}{1} {2} {3}",
                    "HTTP/",
                    this.ProtocolVersion,
                    (int)this.StatusCode,
                    this.StatusCodeAsString));
            var headerStringBuilder = new StringBuilder();
            foreach (var key in this.Headers.Keys)
            {
                headerStringBuilder.AppendLine(string.Format("{0}: {1}", key, string.Join("; ", this.Headers[key])));
            }

            stringBuilder.AppendLine(headerStringBuilder.ToString());
            if (!string.IsNullOrWhiteSpace(this.Body))
            {
                stringBuilder.AppendLine(this.Body);
            }

            return stringBuilder.ToString();
        }
    }
}