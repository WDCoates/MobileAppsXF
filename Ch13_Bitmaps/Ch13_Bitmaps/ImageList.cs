using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ch13_Bitmaps
{
    [DataContract]
    public class ImageList
    {
        [DataMember(Name = "photos")]
        public List<string> Photos = null;
    }

    public class JsonFlickerFeed
    {
        public string title { get; set;}
        public string link { get; set; }
        public string description { get; set; }
        public string generator { get; set; }
        public IList<Item> items { get; set; }
        public Dictionary<string , Item> Items2 { get; set; }

    }

    public abstract class Item
    {
        public string title { get; set; }
        public string link { get; set; }
        public string media { get; set; }
        public string date_taken { get; set; }
        public string description { get; set; }
        public string published { get; set; }
        public string author { get; set; }
        public string author_id { get; set; }
        public string tags { get; set; }

    }

}