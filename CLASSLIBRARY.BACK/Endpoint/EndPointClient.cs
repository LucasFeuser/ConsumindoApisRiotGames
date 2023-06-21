
using CLASSLIBRARY.BACK.Interfaces;

namespace CLASSLIBRARY.BACK.Endpoint
{
    public class EndPointClient: IEndPointClient
    {
        private readonly HttpClient _httpClient;

        public EndPointClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> BuscarPuuidAsync(string endpoint)
        {
            _httpClient.DefaultRequestHeaders.Add("X-Riot-Token", "RGAPI-169c4595-956e-439f-b800-06e2bab56e86");

            var response = await _httpClient.GetAsync(endpoint);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
