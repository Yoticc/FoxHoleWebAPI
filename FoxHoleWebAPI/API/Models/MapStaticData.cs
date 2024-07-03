namespace FoxHoleWebAPI;
public record MapStaticData(
    [JsonProperty("regionId")] int RegionID,
    [JsonProperty("scorchedVictoryTowns")] int ScorchedVictoryTowns,
    [JsonProperty("mapItems")] object[] Items,
    [JsonProperty("mapItemsC")] object[] ItemsC,
    [JsonProperty("mapItemsW")] object[] ItemsW,
    [JsonProperty("mapTextItems")] MapStaticData.TextItem[] TextItems,
    [JsonProperty("lastUpdated")] double LastUpdatedUnix,
    [JsonProperty("version")] int Version
)
{
    [JsonIgnore] public DateTime LastUpdated => TimeUtils.FromUnix(LastUpdatedUnix);

    public record TextItem(
        [JsonProperty("text")] string Text,
        [JsonProperty("x")] double X,
        [JsonProperty("y")] double Y,
        [JsonProperty("mapMarkerType")] string Major
    );
}