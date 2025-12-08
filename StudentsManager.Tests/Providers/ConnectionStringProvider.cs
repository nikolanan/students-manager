using System.IO;
using Newtonsoft.Json;
using StudentsManager.Tests.Models;

namespace StudentsManager.Tests.Providers;

internal static class ConnectionStringProvider
{
    internal static string GetConnectionString()
    {
        var file = File.ReadAllText("appsettings.json");
        var appSettings = JsonConvert.DeserializeObject<AppSettingsRoot>(file);
        return appSettings?.ConnectionStrings.DefaultConnection;
    }
}