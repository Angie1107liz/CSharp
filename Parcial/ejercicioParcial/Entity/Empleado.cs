using ejercicioParcial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioParcial.Entity
{
    public class Empleado : Persona, ICalculable
    {
        public double Salario { get; set; }
        public int DiasTrabajados   { get; set; }



        public Empleado(double salario, int diasTrabajados)
        {
            Salario = salario;
            DiasTrabajados = diasTrabajados;
        }
        public Empleado()
        {
        }

        public double calcularSalario()
        {
            double SalarioDia = Salario / 31;
            double SalarioTotal = SalarioDia * DiasTrabajados;

            return SalarioTotal;
        }
        public async Task LeerSalarioAsync()
        {
            Console.WriteLine("iniciando la lectura del salario:...");
            await Task.Delay(3000); //hace la espera de 3 segundos 
            Console.WriteLine("se complemento el proceso");
            Console.WriteLine($"total a pagar: {calcularSalario()}");
        }

        //ACA SE SOBRESCRIBE EL METODO 
        public  void InformacionPersona()
        {
            base.InformacionPersona();
            Console.WriteLine($"Los días trabajados son: {DiasTrabajados}");
            Console.WriteLine($"Salario base: {Salario:F2}"); //para el formato de la monedas
        }


    }

}
