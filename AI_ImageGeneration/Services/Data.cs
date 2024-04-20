using System.Text.Json.Serialization;

namespace AI_ImageGeneration.Services;

internal sealed class Data
{
    [JsonPropertyName("revised_prompt")]
    public string RevisedPrompt { get; set; } = string.Empty;

    [JsonPropertyName("url")] 
    public string Url { get; set; } = string.Empty;
}