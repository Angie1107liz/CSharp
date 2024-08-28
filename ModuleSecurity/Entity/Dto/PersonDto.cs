using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Address {get; set;}
        public string Phone { get; set;}
        public string Type_document {  get; set;}
        public string Document {  get; set;}
        public Boolean State { get; set;}
        public DateTime Birth_of_date { get; set;}

    }
}
// El objeto dto nos ayuda a transferir datos entre diferentes capas 