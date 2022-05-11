using System;
using System.Text.Json.Serialization;

    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name {get; set;}

        [JsonPropertyName("id")]
        public int Id {get; set;}

        [JsonPropertyName("base_experience")]
        public int BaseExperience {get; set;}

         [JsonPropertyName("weight")]
        public int Weight {get; set;}

        [JsonPropertyName("location_area_encounters")]
        public string LocationAreaEncounters {get; set;}
    }
