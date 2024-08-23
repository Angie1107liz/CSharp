using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<user> GetById(int id);
        public Task<PagedListDto<UserDto>> GetDataTable(QueryFilterDto filter);
        public Task<User> Save(User entity);
        public Task Update(User entity);
        public Task<User> GetByUsername(string username);
        public Task<User> GetByPassword(string password);
    }
}
