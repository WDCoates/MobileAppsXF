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

    [DataContract]
    public class JsonFlickerFeed
    {
        [DataMember]
        public string title { get; set;}
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string generator { get; set; }

        [DataMember(Name = "Items")]
        public IList<Item> items { get; set; }     
    }

    [DataContract]
    public class Item
    {
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string media { get; set; }
        [DataMember]
        public string date_taken { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string published { get; set; }
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public string author_id { get; set; }
        [DataMember]
        public string tags { get; set; }

    }

    
    public class FlickerFeed
    {
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string generator { get; set; }
        public IList<Itema> items { get; set; }
    }

    public class Itema
    {
        public string title { get; set; }
        public string link { get; set; }
        public M media { get; set; }
        public string date_taken { get; set; }
        public string description { get; set; }
        public string published { get; set; }
        public string author { get; set; }
        public string author_id { get; set; }
        public string tags { get; set; }

    }

    public class M
    {
        public string m { get; set; }
    }
}