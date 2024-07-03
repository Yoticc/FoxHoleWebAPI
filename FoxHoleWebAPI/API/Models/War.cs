using FoxHoleWebAPI.API;

namespace FoxHoleWebAPI;
public record War(
    [JsonProperty("warId")] string ID,
    [JsonProperty("warNumber")] int Ordinal,
    [JsonProperty("winner")] FractionEnum Winner,
    [JsonProperty("conquestStartTime")] double? ConquestStartUnixTimeStamp,
    [JsonProperty("conquestEndTime")] double? ConquestEndUnixTimeStamp,
    [JsonProperty("resistanceStartTime")] double? ConquestResistanceUnixTimeStamp,
    [JsonProperty("requiredVictoryTowns")] int RequiredVictoryTowns
)
{
    [JsonIgnore] public DateTime? ConquestStartTimeStamp => TimeUtils.FromUnix(ConquestStartUnixTimeStamp);
    [JsonIgnore] public DateTime? ConquestEndTimeStamp => TimeUtils.FromUnix(ConquestEndUnixTimeStamp);
    [JsonIgnore] public DateTime? ConquestResistanceTimeStamp => TimeUtils.FromUnix(ConquestResistanceUnixTimeStamp);
};