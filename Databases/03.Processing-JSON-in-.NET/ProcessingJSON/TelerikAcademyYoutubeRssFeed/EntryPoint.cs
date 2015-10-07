namespace TelerikAcademyYoutubeRssFeed
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;

    class EntryPoint
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string rss = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            //string videoXml = "../../video.xml";
            var xml = DownloadXmlData(rss);

            var json = ConvertXmlToJson(xml);

            //PrintVideoTitles(json);

            var videos = GetVideosAsCollection(json);

            GenerateHtml(videos);
        }

        private static string DownloadXmlData(string url)
        {
            var webClient = new WebClient();
            var data = webClient.DownloadData(url);
            var xml = Encoding.UTF8.GetString(data);

            return xml;
        }

        private static string ConvertXmlToJson(string xml)
        {
            var document = new XmlDocument();
            document.LoadXml(xml);

            var json = JsonConvert.SerializeXmlNode(document, Newtonsoft.Json.Formatting.Indented);

            return json;
        }

        private static void PrintVideoTitles(string json)
        {
            var jsonObj = JObject.Parse(json);
            var videoTitles = jsonObj["feed"]["entry"].Select(entry => entry["title"]);

            int line = 1;
            foreach (var title in videoTitles)
            {
                Console.WriteLine("{0}. {1}", line, title);
                line++;
            }
        }

        private static IEnumerable<Video> GetVideosAsCollection(string json)
        {
            var jsonObj = JObject.Parse(json);

            return jsonObj["feed"]["entry"]
                   .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));
        }

        private static void GenerateHtml(IEnumerable<Video> videos)
        {
            var doc = new XDocument();
            doc.AddFirst(new XDocumentType("html", null, null, null));

            var html = new XElement("html");
            var head = new XElement("head");

            var meta = new XElement("meta");
            meta.SetAttributeValue("charset", "UTF - 8");
            head.Add(meta);

            var title = new XElement("title", "Teleik Academy Videos");
            head.Add(title);

            var styles = new XElement("link");
            styles.SetAttributeValue("rel", "stylesheet");
            styles.SetAttributeValue("href", "stylesheet.css");
            head.Add(styles);

            html.Add(head);

            var body = new XElement("body");

            foreach (var video in videos)
            {
                var videoDiv = new XElement("div", new XElement("p", video.Title));
                videoDiv.SetAttributeValue("class", "container");

                var iframe = new XElement("iframe", string.Empty);
                iframe.SetAttributeValue("frameborder", "0");
                iframe.SetAttributeValue("src", @"https://www.youtube.com/embed/" + video.Id);
                videoDiv.Add(iframe);

                var link = new XElement("a", "Watch in YouTube");
                link.SetAttributeValue("href", video.Link);

                videoDiv.Add(link);
                body.Add(videoDiv);
            }

            html.Add(body);
            doc.Add(html);
            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.NewLineOnAttributes = true;
            settings.Indent = true;

            var writter = XmlWriter.Create("../../index.html", settings);
            doc.Save(writter);
            writter.Close();

            //Console.WriteLine("You can find the generated index.html in the main directory");
        }
    }
}
