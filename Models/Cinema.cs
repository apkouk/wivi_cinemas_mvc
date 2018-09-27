using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace cinevo_mvc.Models
{
    [DataContract] 
    public class Cinema
    {

        [JsonProperty("_id")]
        public string _id { get; set; }

        [JsonProperty("Id")]
        public string CinemaId { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Tag")]
        public string Tag { get; set; }
        [JsonProperty("Address")]
        public string Address { get; set; }
        [JsonProperty("Telephone")]
        public string Telephone { get; set; }
        [JsonProperty("Url")]
        public string Url { get; set; }
        [JsonProperty("Latitude")]
        public string Latitude { get; set; }
        [JsonProperty("Longitude")]
        public string Longitude { get; set; }
        [JsonProperty("NightPasses")]
        public string NightPasses { get; set; }
        [JsonProperty("MorningPasses")]
        public string MorningPasses { get; set; }
        [JsonProperty("CheapDay")]
        public string CheapDay { get; set; }
        [JsonProperty("OnlineTickets")]
        public string OnlineTickets { get; set; }
        [JsonProperty("MapUrl")]
        public string MapUrl { get; set; }
        [JsonProperty("TownId")]
        public string TownId { get; set; }
        [JsonProperty("Town")]
        public string Town { get; set; }
    }
}