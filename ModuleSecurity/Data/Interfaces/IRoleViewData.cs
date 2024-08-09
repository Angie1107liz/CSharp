using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRoleViewData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<RoleView> GetById(int id);
        public Task<PagedListDto<RoleViewDto>> GetDataTable(QueryFilterDto filter);
        public Task<RoleView> Save(RoleView entity);
        public Task Update(RoleView entity);
    }
}
