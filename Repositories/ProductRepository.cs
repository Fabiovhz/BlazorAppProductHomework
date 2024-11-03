using BlazorAppProductHomework.Models;
using BlazorAppProductHomework.Repositories.Interfaces;

namespace BlazorAppProductHomework.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private Product[] products = new Product[] //creamos un array de productos
        {
            new Product { Id = 1,Name = "Coca",Price = 525.00m,Description = "Coca rica" }
        };

        public Product GetProduct(int id)
        {
            //return new Product
            //{
            //    Id = 1,
            //    Name = "Coca",
            //    Price = 525.00m,
            //    Description = "Coca rica"
            //};

            foreach (var product in products) //verificamos que el id exista
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
