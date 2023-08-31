using IDHEALTH.Models;

namespace IDHEALTH.Interface
{
    public interface ICategory
    {

        Task InsertCategory(Category category);

        Task UpdateCategory(Category category);

        Task<List<Category>> GetAllCategories();

    }
}
