using Pagos360ApiClientLibrary.Model;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Services
{
    public static class ApiRestServices
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        public static async Task<PaginationResult<T>> ListObjectsAsync<T>(string pPath, string pAPIKey)
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", pAPIKey);

            var response = await client.GetAsync(pPath);

            if (response.IsSuccessStatusCode)
            {
                var streamTask = await response.Content.ReadAsStreamAsync();
                var responseObjects = (await JsonSerializer.DeserializeAsync<PaginationResult<T>>(streamTask, jsonSerializerOptions))!;
                return responseObjects;
            }
            else
            {
                string message = await GetErrorMessageAsync(response);
                throw new ApplicationException(message);
            }
        }

        public static async Task<T> CreateObjectAsync<T>(string pPath, string pAPIKey, string rootName, T pObject) where T : class
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", pAPIKey);

            string json = JsonSerializer.Serialize(pObject, jsonSerializerOptions);
            json = "{ \"" + rootName + "\": " + json + "}";
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(pPath, httpContent);

            if (response.IsSuccessStatusCode)
            {
                var streamTask = await response.Content.ReadAsStreamAsync();
                var responseObject = (await JsonSerializer.DeserializeAsync<T>(streamTask, jsonSerializerOptions))!;
                return responseObject;
            }
            else
            {
                string message = await GetErrorMessageAsync(response);
                throw new ApplicationException(message);
            }
        }

        public static async Task<T> CreateObjectWithAccountAsync<T>(string pPath, string pAPIKey, string? pConnectAccount, string rootName, T pObject) where T : class
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", pAPIKey);

            if (pConnectAccount != null) client.DefaultRequestHeaders.Add("X-Connect-Account", pConnectAccount);

            string json = JsonSerializer.Serialize(pObject, jsonSerializerOptions);
            json = "{ \"" + rootName + "\": " + json + "}";
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(pPath, httpContent);

            if (response.IsSuccessStatusCode)
            {
                var streamTask = await response.Content.ReadAsStreamAsync();
                var responseObject = (await JsonSerializer.DeserializeAsync<T>(streamTask, jsonSerializerOptions))!;
                return responseObject;
            }
            else
            {
                string message = await GetErrorMessageAsync(response);
                throw new ApplicationException(message);
            }
        }

        public static async Task<T> GetObjectAsync<T>(string pPath, string pAPIKey, int pId) where T : class
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", pAPIKey);

            var response = await client.GetAsync(pPath + "/" + pId);

            if (response.IsSuccessStatusCode)
            {
                var streamTask = await response.Content.ReadAsStreamAsync();
                var responseObjects = (await JsonSerializer.DeserializeAsync<T>(streamTask, jsonSerializerOptions))!;
                return responseObjects;
            }
            else
            {
                string message = await GetErrorMessageAsync(response);
                throw new ApplicationException(message);
            }
        }

        public static async Task<T> DeleteObjectAsync<T>(string pPath, string pAPIKey, int pId) where T : class
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", pAPIKey);

            var response = await client.DeleteAsync(pPath + "/" + pId);

            if (response.IsSuccessStatusCode)
            {
                var streamTask = await response.Content.ReadAsStreamAsync();
                var responseObject = (await JsonSerializer.DeserializeAsync<T>(streamTask, jsonSerializerOptions))!;
                return responseObject;
            }
            else
            {
                string message = await GetErrorMessageAsync(response);
                throw new ApplicationException(message);
            }
        }

        public static async Task<T> CancelObjectAsync<T>(string pPath, string pAPIKey, int pId) where T : class
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", pAPIKey);

            var response = await client.PutAsync(pPath + "/" + pId + "/cancel", null);
            if (response.IsSuccessStatusCode)
            {
                var streamTask = await response.Content.ReadAsStreamAsync();
                var responseObject = (await JsonSerializer.DeserializeAsync<T>(streamTask, jsonSerializerOptions))!;
                return responseObject;
            }
            else
            {
                string message = await GetErrorMessageAsync(response);
                throw new ApplicationException(message);
            }
        }

        public static async Task<string> GetFirstDudeDateAsync<T>(string pPath, string pAPIKey, string rootName, T pObject) where T : class
        {
            using HttpClient client = new();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", pAPIKey);

            string json = JsonSerializer.Serialize(new { Property = rootName, Value = pObject }, jsonSerializerOptions);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(pPath, httpContent);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                string message = await GetErrorMessageAsync(response);
                throw new ApplicationException(message);
            }
        }


        private static async Task<string> GetErrorMessageAsync(HttpResponseMessage response)
        {
            string errorResult = await response.Content.ReadAsStringAsync();

            string startString = "\"errors\":[";
            string endString = "]";

            int startIndex = errorResult.IndexOf(startString);
            if (startIndex == -1) return "Error parsing error message."; // Added check for -1 return value

            int endIndex = errorResult.IndexOf(endString, startIndex);
            if (endIndex == -1) return "Error parsing error message."; // Added check for -1 return value

            string message = errorResult.Substring(startIndex + startString.Length, endIndex - (startIndex + startString.Length));

            return message;
        }
    }
}
