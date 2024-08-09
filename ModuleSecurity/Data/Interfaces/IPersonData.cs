using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IPersonData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<Person> GetById(int id);
        public Task<PagedListDto<PersonDto>> GetDataTable(QueryFilterDto filter);
        public Task<Person> Save(Person entity);
        public Task Update(Person entity);
        public Task<Person> GetByFirst_name(string first_name);
    }
}
