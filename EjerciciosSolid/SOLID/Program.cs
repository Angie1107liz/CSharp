// See https://aka.ms/new-console-template for more information
using SOLID;
using SOLID.Models;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.DIP;
namespace SOLID
{
    class Program
    {
        static void Main(string[] args) { //este es el metodo, punto de entrada de la aplicacion
            var AnimalesServices = new AnimalesServices(); //aqui se crea la instancia de la clase AnimalesServices y se almacena en la variable AnimalesServices()

            //aca se crea una nueva instancia de la clase animal y se la pasa 
            //por cada parametro del constructor-.
            var burro = new Burro("Igor");
            var conejo = new Conejo("Rabbit");
            var jirafa = new Jirafa("chikirilu");

            // esta linea llama el metodode la instancia pasandola como parametro
            //tambien imprime la informacion
            AnimalesServices.DetalleAnimales(conejo);
            AnimalesServices.DetalleAnimales(burro);
            AnimalesServices.DetalleAnimales(jirafa);

            var zoologo1 = new
                Zoologo("Angie Trujillo");
            var zoologo2 = new
                Zoologo("Andres Morales");
            var zoologo3 = new
                Zoologo("Mechas y bruno");

            //esto asigna un zoologo a cada animal 
            zoologo1.Alimentar(conejo);
            zoologo2.Alimentar(burro);
            zoologo3 .Alimentar(jirafa);
        }

    }
}