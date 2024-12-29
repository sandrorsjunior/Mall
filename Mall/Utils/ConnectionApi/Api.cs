using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Mall.ApiConnection.DTO;
using Mall.Utils.ConnectionApi.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mall.Utils.ConnectionApi{
    class Api{
        private string _url;
        private static HttpClient? _client;

        public Api(string url)
        {
            Api._client = null;
            this._url = url;
        }

        private HttpClient GetClient()
        {
            if (Api._client == null)
            {
                Api._client = new HttpClient();
            }
            return Api._client;
        }
        public async Task<ResponseMessageDTO<T>> alternativePost<T>(string endpoint, PostDTO<T> data){
            string jsonData = JsonSerializer.Serialize(data.Content);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            string url = this._url + endpoint;
            var client = this.GetClient();
            try
            {
                HttpResponseMessage clientResponse = await client.PostAsync(url, content);
                var responseSerialized = await clientResponse.Content.ReadAsStringAsync();
                var responseMessage = JsonSerializer.Deserialize<ResponseMessageDTO<T>>(responseSerialized);
                if (responseMessage != null) {
                    responseMessage.StatusCode = clientResponse.StatusCode;
                    return responseMessage;
                }
                var DeserializeErroMessage = new ResponseMessageDTO<T>
                {
                    Message = "Wasn't possibly Deserializer!",
                    StatusCode = HttpStatusCode.NoContent,
                };
                return DeserializeErroMessage;
            }
            catch (Exception ex) {
                var responseMessage = new ResponseMessageDTO<T>{
                    Message = "There was some issus!",
                    StatusCode = HttpStatusCode.InternalServerError,
                };
                Console.WriteLine(ex.Message);
                return responseMessage;
            }

            client.Dispose();
        }

        public async Task<ResponseMessageDTO<T>> Get<T>(string endpoint) {
            string url = this._url + endpoint;
            var client = this.GetClient();
            HttpResponseMessage clientResponse = await client.GetAsync(url);
            var response = await this.GetResponseData<T>(endpoint, clientResponse, url);
            client.Dispose();
            return response;
        }

        public async Task<ResponseMessageDTO<T>> Post<T>(string endpoint, PostDTO<T> data)
        {
            string jsonData = JsonSerializer.Serialize(data.Content);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            string url = this._url + endpoint;
            var client = this.GetClient();
            HttpResponseMessage clientResponse = await client.PostAsync(url, content);
            var response = await this.GetResponseData<T>(endpoint, clientResponse, url);
            client.Dispose();
            return response;
        }
        private async Task<ResponseMessageDTO<T>> GetResponseData<T>(string endpoint, HttpResponseMessage clientResponse, string url)
        {
            ResponseMessageDTO<T> responseMessageDTO = new();
            try
            {
                var responseSerialized = await clientResponse.Content.ReadAsStringAsync();
                var responseMessage = JsonSerializer.Deserialize<ApiMessageDTO<T>>(responseSerialized);
                if (responseMessage != null)
                {
                    responseMessageDTO.StatusCode = clientResponse.StatusCode;
                    responseMessageDTO.Data = responseMessage.data;
                    responseMessageDTO.Message = responseMessage.message;
                    return responseMessageDTO;
                }
                responseMessageDTO.Message = "Wasn't possibly Deserializer!";
                responseMessageDTO.StatusCode = HttpStatusCode.NoContent;
                return responseMessageDTO;
            }
            catch (Exception ex)
            {
                var responseMessage = new ResponseMessageDTO<T>
                {
                    Message = "There was some issus!",
                    StatusCode = HttpStatusCode.InternalServerError,
                };
                Console.WriteLine(ex.Message);
                return responseMessage;
            }
        }
    }
}
