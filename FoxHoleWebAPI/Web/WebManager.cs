namespace FoxHoleWebAPI;
public record WebManager(string EndPoint, HttpClient Client)
{
    string GetUrl(string path) => EndPoint + path;

    public string GetString(string path) => Client.GetStringAsync(GetUrl(path)).GetAwaiter().GetResult();
    public T GetJson<T>(string path) => JsonConvert.DeserializeObject<T>(GetString(path))!;
}