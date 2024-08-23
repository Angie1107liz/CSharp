using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IPersonData
    {
        Task Delete(int id); // Elimina el modificador 'public'
        Task<IEnumerable<DataSelectDto>> GetAllSelect(); // Elimina el modificador 'public'
        Task<Person> GetById(int id); // Elimina el modificador 'public'
        Task<PagedListDto<PersonDto>> GetDataTable(QueryFilterDto filter); // Elimina el modificador 'public'
        Task<Person> Save(Person entity); // Elimina el modificador 'public'
        Task Update(Person entity); // Elimina el modificador 'public'
        Task<Person> GetByFirst_name(string first_name); // Elimina el modificador 'public'
    }
}
