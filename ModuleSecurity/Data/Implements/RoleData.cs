using Data.Interfaces;
using Entity.Context;
using Entity.Dto;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implements
{
    public class RoleData:IRoleData
    {
        private readonly AplicationDBContext context;
        protected readonly IConfiguration configuration;
        public RoleData(AplicationDBContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                throw new Exception("Registro no encontrado");
            }
            entity.DeleteAd = DateTime.Parse(DateTime.Today.ToString());
            context.Roles.Update(entity);
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT 
                        Id,
                        CONCAT(First_name, ' - ', Last_name, ' - ', Email, ' - ', Phone, ' - ', Addres, ' - ', Type_document, ' - ', Document) AS TextoMostrar 
                    FROM 
                        Security.Person
                    WHERE Deleted_at IS NULL AND State = 1
                    ORDER BY Id ASC";
            return await context.QueryAsync<DataSelectDto>(sql);
        }

        public async Task<Role> Save(Role entity)
        {
            context.Roles.Add(entity);
            await context.SaveChangesAsync();
            return entity;

        }
        public async Task Update(Role entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
        }
        public async Task <Role> GetByName(string name)
        {
            return await this.context.Roles.AsNoTracking().Where(item => item.Name == name).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Role>> GetAll()
        {
            var sql = @"SELECT * FROM Role ORDER bY id ASC";
            return await this.context.QueryAsync<Role> (sql);
        }
        Task<IEnumerable<DataSelectDto>> IRoleData.GetAllSelect()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedListDto<RoleDto>> GetDataTable(QueryFilterDto filter)
        {
            throw new NotImplementedException();
        }
    }
}
