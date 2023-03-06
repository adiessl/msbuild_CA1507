using Newtonsoft.Json;

namespace ConsoleApp;

internal sealed class DataTransferObject
{
    [JsonProperty("Test")]
    public string? Test { get; set; }
}