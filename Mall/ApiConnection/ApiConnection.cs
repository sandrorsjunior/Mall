using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class ApiConnection
{
    private string _url;
    private string _responseMenssage;
    private static HttpClient? _client;

    public ApiConnection(string url)
    {
        ApiConnection._client = null;
        this._url = url;
        this._responseMenssage = string.Empty;
    }

    private HttpClient GetClient()
    {
        if(ApiConnection._client == null)
        {
            ApiConnection._client = new HttpClient();
        }
        return ApiConnection._client;
    }
    public async Task<string> GetUser()
    {
        var client = this.GetClient();
        List<string> allUsers = new List<string>();
        try
        {
            HttpResponseMessage response = await client.GetAsync(this._url);
            if (response.IsSuccessStatusCode)
            {
                this._responseMenssage = await response.Content.ReadAsStringAsync();
                List<ApiDTO> jsonResult = JsonSerializer.Deserialize<List<ApiDTO>>(this._responseMenssage);
                if (jsonResult != null) 
                {
                    foreach (var data in jsonResult)
                    {
                        allUsers.Add(data.name);
                    }
                }
                
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
            MessageBox.Show(string.Join(",", allUsers));
            return this._responseMenssage;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception occurred: {ex.Message}");
            throw new Exception("Deu ruim negão!");
        }
        finally
        {
            client.Dispose();
        }

    }
}
