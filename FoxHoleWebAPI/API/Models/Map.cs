namespace FoxHoleWebAPI;
public record Map(
    string Name, 
    [JsonProperty("totalEnlistments")] int Enlistments,
    [JsonProperty("colonialCasualties")] int Colonials,
    [JsonProperty("wardenCasualties")] int Wardens,
    [JsonProperty("dayOfWar")] int Day
);