namespace BigCommerce_Server.Services
{
    public class BigCommerceNonB2B_Service
    {
        private readonly HttpClient _httpClient;

        public BigCommerceNonB2B_Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(Environment.GetEnvironmentVariable("BC_NON_B2B_ENDPOINT_V2"));
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
            _httpClient.DefaultRequestHeaders.Add("X-Auth-Token", Environment.GetEnvironmentVariable("BC_NON_B2B_V2_TOKEN"));
        }
    }
}
