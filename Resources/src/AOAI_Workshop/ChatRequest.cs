using Newtonsoft.Json;


public class ChatRequest
{
    [JsonProperty("history")]
    public required List<History> History { get; set; }

    [JsonProperty("prompt")]
    public required string Prompt { get; set; }
}

public class History
{
    [JsonProperty("content")]
    public required string Content { get; set; }

    [JsonProperty("role")]
    public required string Role { get; set; }
}
