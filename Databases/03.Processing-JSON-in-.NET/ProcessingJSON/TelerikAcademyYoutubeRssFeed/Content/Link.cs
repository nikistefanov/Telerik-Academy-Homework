namespace TelerikAcademyYoutubeRssFeed
{
    using Newtonsoft.Json;

    public class Link
    {
        [JsonProperty("@href")]
        public virtual string Href { get; set; }
    }
}
