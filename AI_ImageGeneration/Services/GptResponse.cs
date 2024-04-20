using System.Text.Json.Serialization;

namespace AI_ImageGeneration.Services;

internal sealed class GptResponse
{
    [JsonPropertyName("created")]
    public int Created { get; set; }

    [JsonPropertyName("data")]
    public List<Data> Data { get; set; } = new();
}