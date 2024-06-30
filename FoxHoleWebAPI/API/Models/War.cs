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
    public DateTime? ConquestStartTimeStamp => TimeUtils.FromUnix(ConquestStartUnixTimeStamp);
    public DateTime? ConquestEndTimeStamp => TimeUtils.FromUnix(ConquestEndUnixTimeStamp);
    public DateTime? ConquestResistanceTimeStamp => TimeUtils.FromUnix(ConquestResistanceUnixTimeStamp);
};