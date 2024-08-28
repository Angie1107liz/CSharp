using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implements
{
    public class PersonBussiness : IPersonBussiness
    {
        protected readonly IPersonData data;
        private IEnumerable<object> person;

        public PersonBussiness(IPersonData data)
        {

            this.data = data;
        }
        public Task<IEnumerable<PersonDto>> All=> throw new NotImplementedException();  
        public async Task Delete (int id)
        {
            await this.data.Delete(id);
        }
        public async Task <IEnumerable<PersonDto>> GetAll()
        {
            IEnumerable<Module>modules=await this .data.GetAll();
            var personDto = person.Select(person => new PersonDto
            {
                Id = person.Id,
                First_name = person.First_name,
                Last_name = person.Last_name,
                Email = person.Email,
                Address = person.Address,
                Type_document = person.Type_document,
                Document = person.Document,
                Birth_of_date = person.Birth_of_date,
                Phone = person.Phone,
                State = person.State,


            });
        }
    
    }
}
