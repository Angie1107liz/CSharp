using System;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dto;

namespace Data.Interfaces
{
    public interface IRoleData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<Role> GetById(int id);
        public Task<PagedListDto<RoleDto>> GetDataTable(QueryFilterDto filter);
        public Task<Role> Save(Role entity);
        public Task Update(Role entity);
    }
}
