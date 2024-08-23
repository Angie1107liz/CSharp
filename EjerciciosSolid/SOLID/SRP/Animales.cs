using SOLID.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    //aca se puede evidenciar el primer principio ya que creamos una clase padre
    //ya que en ella se pueden implementar otras subclases sin modificarse
    public class Animales:IAnimal
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public Animales(string nombre, string especie)
        {
            Nombre = nombre;
            Especie = especie;
        }

    }
}
