namespace BigCommerce_Server.Services
{
    public class BigCommerceB2B_Service
    {
        private readonly HttpClient _httpClient;

        public BigCommerceB2B_Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(Environment.GetEnvironmentVariable("BC_B2B_ENDPOINT"));
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
            _httpClient.DefaultRequestHeaders.Add("authToken", Environment.GetEnvironmentVariable("BC_B2B_TOKEN"));
         
        }


    }
}
