using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class UserRoleDto
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string User {  get; set; }
        public int Role_Id { get; set; }
        public string Role { get; set; }
        public Boolean State {  get; set; }
    }
}
