using Entity.Dto;
using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IModuleData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetDataSelect();
        public Task<Module> GetById(int id);
        public Task<PagedListDto<ModuleDto>> GetDataTable(QueryFilterDto filter);
        public Task<Module> Save(Module entity);
        public Task Update(Module entity);
        public Task <Module> GetByName(String name);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<Module>> GetAll();
    }
}
