using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IModuloData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetDataSelect();
        public Task<Modulo> GetById(int id);
        public Task<PagedListDto<ModuloDto>> GetDataTable(QueryFilterDto filter);
        public Task<Modulo> Save(Modulo entity);
        public Task Update(Modulo entity);
        public Task <Modulo> GetByName(String name);
    }
}
