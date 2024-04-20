using System.Text.Json.Serialization;

public sealed class OpenAIPrompt
{
    [JsonPropertyName("model")]
    public string model { get; set; }

    [JsonPropertyName("prompt")]
    public string prompt { get; set; }

    [JsonPropertyName("n")] 
    public int n => 1;

    [JsonPropertyName("size")]
    public string size => "1024x1024";
}