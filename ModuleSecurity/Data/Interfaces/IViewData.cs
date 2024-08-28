using System;
using Data.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Entity.Dto;

namespace Data.Interfaces
{
    public interface IViewData
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<View> GetById(int id);
        public Task<PagedListDto<ViewDto>> GetDataTable(QueryFilterDto filter);
        public Task<View> Save(View entity);
        public Task Update(View entity);
        public Task<View> GetByName(string name);
        Task<IEnumerable<View>> GetAll();
    }
}
