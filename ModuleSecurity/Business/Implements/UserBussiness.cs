using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Entity.Model.Security;

namespace Business.Implements
{
    public class UserBussiness : IUserBussiness
    {
        private readonly IUserData data;
        public UserBussiness (IUserData data)
        {
            this.data = data;
        }
            public async Task Delete (int id)
            {
                 await data.Delete(id);
            }
            public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
            {
                return await data.GetAllSelect();
            }
        public async Task<UserDto> GetById(int id)
        {
            User user = await data.GetById(id);
            UserDto UserDto = new UserDto();

            UserDto.Id = user.Id;
            UserDto.Username = user.Username;
            UserDto.Password = user.Password;
            UserDto.PersonId = user.PersonId;
            UserDto.State = user.State;
            return UserDto;

        }
            public async Task <UserDto>
        }
    public  async Task <PagedListDto<UserDto>> GetDataTable(QueryFilterDto filters)
    {
        return await data.GetDataTable(filters);
    }
    public async Task Save (UserDto entity)
    {
        User user = new User();
        user = mapearDatos(user, entity);
    }
    public async Task Update(int id, UserDto entity)
    {
        User user = await Database.GetById(id);
        if (user == null)
        {
            throw new Exception("Registro no encontrado");
        }
        user = mapearDatos(user, entity);
        await Database.Update(user);
    }
    private User mapearDatos(User user, UserDto entity)
    {
        user.Id = entity.Id;
        user.Username = entity.Username;
        user.Password = entity.Password;
        user PersonId = entity.PersonId;
        user.State = entity State;

        return user;
    }

   }
}
