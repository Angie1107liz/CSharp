using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioParcial.Entity
{
    public class Persona
    {

        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Direccion { get; set; }

        //constructor con parametros 
        public Persona(String nombre, int edad, String direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }
        //constructor sin parametros 
        public Persona()
        {


        }
        //metodo para ver la informacion de la persona
        //Hace que pueda se implementada en otras clases(la prepara)

        /*public virtual void IngresarInformacionPersona() //El metodo Main es para ver como se crea objetos en la clase 
        {
            Console.WriteLine($"Nombre: {Nombre} Edad: {Edad} Direccion:{Direccion}");
        }*/
        public virtual void IngresarDatosPersona()
        {
            Console.Write("Ingresa el nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("ingresa la edad: ");
            Edad=int.Parse(Console.ReadLine());

            Console.Write("ingresa la Direccion: ");
            Direccion = Console.ReadLine();

        }
        public void InformacionPersona()
        {
            Console.WriteLine($"Nombre{Nombre}");
            Console.WriteLine($"Edad{Edad}");
            Console.WriteLine($"Direccion{Direccion}");
        }
        /*public async Task leerDatos()
        {
            Console.WriteLine("Esta leyendo los datos...");
            await Task.Delay(3000);//son los milesegundos que se retrasan
            Console.WriteLine("Los datos estan leídos");
            mostrarInformacion();*/

        }
    }

