using System.Text.Json.Serialization;

namespace web_api.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CharacterClass
    {
        Fighter = 1,
        Mage = 2,
        Thief = 3,
        // I'm not racist. These are the character classes available in South Park: The stick of truth
        Jew = 4
    }
}