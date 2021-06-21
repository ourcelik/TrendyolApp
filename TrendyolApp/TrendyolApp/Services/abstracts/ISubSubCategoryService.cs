using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services.abstracts
{
    public interface ISubSubCategoryService
    {
        public Task<DataModel<SubSubCategoryModel>> GetSubSubCategoriesAsync();
    }
}
