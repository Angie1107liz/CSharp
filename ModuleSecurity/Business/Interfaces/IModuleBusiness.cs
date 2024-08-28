using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IModuleBusiness
    {
        public Task Delete(int id);
        public Task <ModuleDto> GetById(int id);
        public Task<IEnumerable<ModuleDto>> All { get; }
        public Task<IEnumerable<DataSelectDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>>GetAllSelect();
        public Task <Module> Save(ModuleDto entity);
        public Task Update (ModuleDto entity);



    }
}
