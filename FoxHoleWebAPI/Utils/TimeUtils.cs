namespace FoxHoleWebAPI;
internal static class TimeUtils
{
    public static DateTime? FromUnix(double? seconds) => seconds is not null ? new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(seconds.Value).ToLocalTime() : null;
    public static DateTime FromUnix(double seconds) => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(seconds).ToLocalTime();
}