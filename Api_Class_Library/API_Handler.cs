using System.Net.Http.Json;

namespace Api_Class_Library {
    public class API_Handler {
        private readonly HttpClient client;
        private readonly string rootUrl;

        public API_Handler(string rootUrl) {
            HttpClientHandler handler = new() {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };
            client = new(handler);
            this.rootUrl = rootUrl;
        }

        public async Task<ApiResponseCodeMessage> PostToServer(string routeName, string name, string surname, string age) {
            Dictionary<string, string> requestDict = new(){
                    { "name", name },
                    { "surname", surname },
                    { "age", age }
            };

            FormUrlEncodedContent request = new(requestDict);

            HttpResponseMessage response = await client.PostAsync($"{this.rootUrl}/{routeName}", request);

            ApiResponseCodeMessage? decodedResponse = await response.Content.ReadFromJsonAsync<ApiResponseCodeMessage>();
            return decodedResponse ?? throw new ResponseNullException("API reponse is Null!");
        }

        public async Task<ApiResponseOne> GetFromServer(string routeName, string criteria, string search) {
            Dictionary<string, string> requestDict = new() {
                { "criteria", criteria },
                { "search", search }
            };
            FormUrlEncodedContent content = new(requestDict);

            HttpResponseMessage response = await client.PostAsync($"{this.rootUrl}/{routeName}", content);

            ApiResponseOne? decodedResponse = await response.Content.ReadFromJsonAsync<ApiResponseOne>();
            return decodedResponse ?? throw new ResponseNullException("API reponse is Null!");
        }

        public async Task<ApiResponseMany> GetManyServer(string routeName, string age) {
            Dictionary<string, string> requestDict = new() {
                { "age", age }
            };
            FormUrlEncodedContent content = new(requestDict);

            HttpResponseMessage response = await this.client.PostAsync($"{this.rootUrl}/{routeName}", content);

            ApiResponseMany? decodedResponse = await response.Content.ReadFromJsonAsync<ApiResponseMany>();
            return decodedResponse ?? throw new ResponseNullException("API reponse is Null!");
        }

        public async Task<ApiResponseCodeMessage> DeleteFromServer(string routeName, string id) {
            Dictionary<string, string> requestDict = new() {
                { "_id", id }
            };
            FormUrlEncodedContent content = new(requestDict);

            HttpResponseMessage response = await this.client.DeleteAsync($"{this.rootUrl}/{routeName}/{id}");
            response.EnsureSuccessStatusCode();

            ApiResponseCodeMessage? decodedResponse = await response.Content.ReadFromJsonAsync<ApiResponseCodeMessage>();
            return decodedResponse ?? throw new ResponseNullException("API reponse is Null!");
        }
    }
}
