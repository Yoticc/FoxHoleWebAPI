namespace FoxHoleWebAPI;
public class WarClient
{
    internal const string Endpoint = "https://war-service-live.foxholeservices.com/api/";

    public WarClient() : this(new()) { }
    public WarClient(HttpClient httpClient) => Client = new(Endpoint, httpClient);

    public readonly WebManager Client;

    public War CurrentWar => Client.GetJson<War>("worldconquest/war");
    public List<string> MapNames => Client.GetJson<List<string>>("worldconquest/maps");
    public bool IsMapHasData(string mapName) => mapName is not "HomeRegionC" and not "HomeRegionW";
    public Map GetMapData(string mapName) => Client.GetJson<Map>($"worldconquest/warReport/{mapName}");
    public MapStaticData GetMapStaticData(string mapName) => Client.GetJson<MapStaticData>($"worldconquest/warReport/{mapName}/static");
    public MapDynamicData GetMapDynamicData(string mapName) => Client.GetJson<MapDynamicData>($"worldconquest/warReport/{mapName}/dynamic/public");
}