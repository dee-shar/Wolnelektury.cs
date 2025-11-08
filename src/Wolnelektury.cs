using System.Net.Http;

namespace WolnelekturyApi
{
    public class Wolnelektury
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://wolnelektury.pl/api";
        public Wolnelektury()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetBooks()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/books");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetAudioBooks()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/audiobooks");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetDaisy()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/daisy");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAuthors()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/authors");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetEpochs()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/epochs");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetGenres()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/genres");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetKinds()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/kinds");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetThemes()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/themes");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetCollections()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/collections");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
