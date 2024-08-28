using Entity.Dto;
using Entity.Context;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using com.sun.tools.corba.se.idl.constExpr;


namespace Data.Implements
{
    public class ModuleData
    {
        private readonly AplicationDBContext context;
        protected readonly IConfiguration configuration;

        public ModuleData(AplicationDBContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public async Task Delete(int id)
        {
        var entity = await GetById(id);
        if(entity    == null)
            {
            throw new Exception("Registro no encontrado");
        }
        entity.Deleted_at = DateTime.Parse(DateTime.Today.ToString());
        context.Modulo.Update(entity);
        await context.SaveChangesAsync();

    }
public async Task <IEnumerable<DataSelectDto>>GetAllSelect()
{
    var sql = @"SELECT
                Id, 
                CONICAT(Name,'-' Description) As TextoMostrar
            FROM
                Security.Modulo
            WHERE Deleted_at IS NULL AND State = 1 
            ORDER BY id ASC";
    return await context.QueryAsync<DataSelectDto>(sql);
}
public async Task <System.Reflection.Module> GetById(int id)
{
    var sql = @"SELECT * FROM Security.Modulo WHERE Id = @Id ORDER BY Id ASC";
    return await this.context.QueryFirstOrDefaultAsync<Entity.Model.Security.Module>(sql new { Id= id });
}
public async Task <Entity.Model.Security.Module> GetByName (String name)
{
    return await this.context.Modulos.AsNoTracking().Where(item=> item.Name == name).FirstOrDefaultAsync();

}
public async Task<Entity.Model.Security.Module> Save (System.Reflection.Module entity)
{
    context.Modulos.Add(entity);
    await context.SaveChangesAsync();
    return entity;
}
public async Task Update(Entity.Model.Security.Module entity )
{
   context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    await context.SaveChanngesAsync();
    }
   }
}

