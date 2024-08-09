using Entity.Dto;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserBussiness
    {
        public Task Delete (int id);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<User> GetById(int id);
        public Task<PagedListDto<UserDto>> GetDataTable(QueryFilterDto filter);
        public Task <User> Save(UserDto entity);
        public Task Update (UserDto entity);
    }
}
