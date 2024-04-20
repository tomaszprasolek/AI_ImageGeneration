using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace AI_ImageGeneration.Services;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class OpenAiPrompt
{
    [JsonPropertyName("model")] 
    public string Model { get; set; } = string.Empty;

    [JsonPropertyName("prompt")] 
    public string Prompt { get; set; } = string.Empty;

    [JsonPropertyName("n")] 
    public int N => 1;

    [JsonPropertyName("size")] 
    public string Size => "1024x1024";
}