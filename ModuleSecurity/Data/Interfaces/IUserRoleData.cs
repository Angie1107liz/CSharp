using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserRoleData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<UserRoleDto> GetById(int id);
        public Task<PagedListDto<UserRoleDto>> GetDataTable(QueryFilterDto filter);
        public Task<UserRoleDto> Save(UserRoleDto entity);
        public Task Update(UserRoleDto entity);
    }
}
