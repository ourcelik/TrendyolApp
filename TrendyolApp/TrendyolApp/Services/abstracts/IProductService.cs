using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services.abstracts
{
    public interface IProductService
    {
        public Task<DataModel<ProductModel>> GetProductsAsync();
    }
}
