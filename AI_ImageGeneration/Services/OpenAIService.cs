using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace AI_ImageGeneration.Services;

internal class OpenAiService
{
    public async Task<GptResponse?> GenerateImageAsync(string apiKey, string userPrompt, string model)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, "https://api.openai.com/v1/images/generations");
        request.Headers.Add("Authorization", $"Bearer {apiKey}");

        var gptPrompt = new OpenAIPrompt
        {
            model = model,
            prompt = userPrompt
        };
        var json = JsonSerializer.Serialize(gptPrompt, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        });
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        request.Content = content;

        var httpResponse = await client.SendAsync(request);
        if (!httpResponse.IsSuccessStatusCode)
        {
            string responseContent = await httpResponse.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
        }
        httpResponse.EnsureSuccessStatusCode();

        var response = await httpResponse.Content.ReadFromJsonAsync<GptResponse>();
        return response;
    }
}