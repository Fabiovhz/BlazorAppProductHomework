using BlazorAppProductHomework.Models;

namespace BlazorAppProductHomework.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
    }
}
