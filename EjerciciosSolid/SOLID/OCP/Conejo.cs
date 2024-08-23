using SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    //Se crean subclases que heredan dde animales para su exteension y no su modificacion
    //aca se cumple el principio abierto cerrado
    public class Conejo : Animales
    {
        public Conejo(string nombre) : base(nombre, "Conejo") { }
    }
}
