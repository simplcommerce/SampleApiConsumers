using SampleApiConsumer.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleApiConsumer.Services
{
    public interface ICategoryApiClient
    {
        Task<IList<CategoryListItem>> GetCategories();
    }
}
