using System.Text.Json;
using Mall.ApiConnection.DTO;

namespace Mall.ApiConnection
{
    class ApiConnection
    {
        private string _url;
        private ResonseProductAPI? _responseMenssage;
        private static HttpClient? _client;

        public ApiConnection(string url)
        {
            ApiConnection._client = null;
            this._url = url;
            this._responseMenssage = null;
        }

        private HttpClient GetClient()
        {
            if (ApiConnection._client == null)
            {
                ApiConnection._client = new HttpClient();
            }
            return ApiConnection._client;
        }
        public async Task<ResonseProductAPI>? executeURL(string endpoint)
        {
            string url = this._url + endpoint;
            var client = this.GetClient();
            List<string> allProducs = new List<string>();
            try
            {
                HttpResponseMessage clientResponse = await client.GetAsync(url);
                if (clientResponse.IsSuccessStatusCode)
                {
                    var response = await clientResponse.Content.ReadAsStringAsync();
                    this._responseMenssage = JsonSerializer.Deserialize<ResonseProductAPI>(response);

                }
                else
                {
                    Console.WriteLine($"Error: {clientResponse.StatusCode}");

                    throw new Exception($"Error: {clientResponse.StatusCode}");
                }
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

}
