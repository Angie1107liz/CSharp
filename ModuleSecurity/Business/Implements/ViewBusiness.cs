using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Business.Implements
{
    public class ViewBusiness : IViewBusiness

    {
        protected readonly IViewData data;

        public ViewBusiness(IViewData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<ViewDto>> GetAll()
        {
            IEnumerable<View> views = await this.data.GetAll();
            var viewDto = views.Select(view => new ViewDto
            {
                Id = view.Id,
                Name = view.Name,
                Description = view.Description, // Corregido: Se estaba usando view.Name en lugar de view.Description
                Route = view.Route,
                Module_id = view.Modulo_id,
                State = view.State
            });

            return viewDto;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<ViewDto> GetById(int id)
        {
            View view = await this.data.GetById(id);
            ViewDto viewDto = new ViewDto();

            viewDto. Id = view.Id;
            viewDto.Name = view.Name;
            viewDto.Description = view.Description;
            viewDto.Route = view.Route;
            viewDto.Module_id = view.Modulo_id;
            viewDto.State = view.State;
            return viewDto;
        }
        public View mapearDatos(View view, ViewDto entity)
        {
            view.Id=entity.Id;
            view.Name = entity.Name;
            view.Description = entity.Description;
            view.Route = entity.Route;
            view.Modulo_id = entity.Module_id;
            view.State = entity.State;

            return view;
        }
        public async Task<View> Save(ViewDto entity)
        {
            View view = new View();
            view.Created_at = DateTime.Now.AddHours(-5);
            view = this.mapearDatos(view, entity);
            view.Module = null;

            return await this.data.Save(view);
        }

        public Task<ViewDto> save(ViewDto viewDto)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ViewDto entity)
        {
            View view = await this.data.GetById(entity.Id);
            if (view == null)
            {
                throw new Exception("Registro no encontrado");
            }

            view = this.mapearDatos(view, entity);
            await this.data.Update(view);
        }

        
    }
}
