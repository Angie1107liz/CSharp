using SOLID.ISP;
using SOLID.Models;
using SOLID.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class Zoologo
    {
        public string Name { get; set; }
        public Zoologo(string name)
        {
            Name = name;
        }
        public void Alimentar(IAnimal animales)
        {
            Console.Write("------");
            Console.WriteLine($"{Name}  esta alimentando {animales.Nombre},que es un {animales.Especie}.");
        }
    }
}
