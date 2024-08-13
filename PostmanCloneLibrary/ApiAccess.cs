using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(
        string apiUrl,
        bool formatOutput = true,
        HttpAction action = HttpAction.GET)
    {
        var response = await client.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();

            if (formatOutput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer
                    .Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }

    public bool IsValidApiUrl(string apiUrl)
    {
        if (string.IsNullOrEmpty(apiUrl))
        {
            return false;
        }

        bool output = Uri.TryCreate(apiUrl, UriKind.Absolute, out Uri uriOutput) &&
            (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}
