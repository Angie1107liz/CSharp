using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    //esta interfazhacer que represente a llos animales 
    public interface IAnimal
    {
        string Nombre { get; }
        string Especie { get; }
    }
}
