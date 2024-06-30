using FoxHoleWebAPI.API;

namespace FoxHoleWebAPI;
public record MapDynamicData(
    [JsonProperty("regionId")] int RegionID,
    [JsonProperty("scorchedVictoryTowns")] int ScorchedVictoryTowns,
    [JsonProperty("mapItems")] MapDynamicData.MapItem[] Items,
    [JsonProperty("mapItemsC")] object[] ItemsC,
    [JsonProperty("mapItemsW")] object[] ItemsW,
    [JsonProperty("mapTextItems")] object[] TextItems,
    [JsonProperty("lastUpdated")] double LastUpdatedUnix,
    [JsonProperty("version")] byte Version
)
{
    public DateTime LastUpdated => TimeUtils.FromUnix(LastUpdatedUnix);

    public record MapItem(
        [JsonProperty("teamId")] FractionEnum Fraction,
        [JsonProperty("iconType")] IconEnum IconType,
        [JsonProperty("x")] double X,
        [JsonProperty("y")] double Y,
        [JsonProperty("flags")] MapFlags Flags,
        [JsonProperty("viewDirection")] int ViewDirection
    );
}