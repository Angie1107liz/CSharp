using SOLID.DIP;
using SOLID.Models;
using SOLID.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    //el principio de responsabilida unica ya que puede sustituirse sin alterar el programa 

    public class AnimalesServices
        //la clase Animales puede ser sustituidads por sus subclases
    {
        public void DetalleAnimales(Animales animales)
        {
            Console.WriteLine($"Animal:{animales.Nombre}, Especies:{animales.Especie}");

        }
    }
}
