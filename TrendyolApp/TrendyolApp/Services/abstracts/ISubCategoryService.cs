using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services.abstracts
{
    public interface ISubCategoryService
    {
        public Task<DataModel<SubCategoryModel>> GetSubCategoriesAsync();
    }
}
