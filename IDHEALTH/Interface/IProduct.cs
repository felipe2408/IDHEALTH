using IDHEALTH.Models;

namespace IDHEALTH.Interface
{
    public interface IProduct
    {

        Task InsertProduct(Product product);

        Task UpdateProduct(Product product);

        Task<List<Product>> GetAllProduct();



    }
}
