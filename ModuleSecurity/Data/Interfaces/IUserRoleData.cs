﻿using Entity.Dto;

namespace Data.Interfaces
{
    public interface IUserRoleData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<UserRole> GetById(int id);
        public Task<PagedListDto<UserRoleDto>> GetDataTable(QueryFilterDto filter);
        public Task<UserRole> Save(UserRole entity);
        public Task Update(UserRole entity);
    }
}
