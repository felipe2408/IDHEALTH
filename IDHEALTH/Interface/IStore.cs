using IDHEALTH.Models;

namespace IDHEALTH.Interface
{
    public interface IStore
    {

        Task InsertStore(Store store);

        Task UpdateStore(Store store);

        Task<List<Store>> GetAllStore();


    }
}
