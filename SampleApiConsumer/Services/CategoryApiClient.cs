using SampleApiConsumer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleApiConsumer.Services
{
    public class CategoryApiClient : ICategoryApiClient
    {
        private readonly HttpClient _client;

        public CategoryApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<IList<CategoryListItem>> GetCategories()
        {
            var response = await _client.GetAsync("api/categories");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IList<CategoryListItem>>();
        }
    }
}
