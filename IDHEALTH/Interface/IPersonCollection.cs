using IDHEALTH.Models;

namespace IDHEALTH.Interface
{
    public interface IPersonCollection
    {

        Task InsertPeople(Person person);

        Task UpdatePeople(Person person);


        Task<List<Person>> GetAllPeople();

    }
}
