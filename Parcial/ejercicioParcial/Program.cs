// See https://aka.ms/new-console-template for more information
using ejercicioParcial.Entity;

public class Program
{
     static async Task Main(string[] args)
    {
        Empleado empleado = new Empleado();

        empleado.IngresarDatosPersona();

        Console.Write("digite el salario");
        empleado.Salario=double.Parse(Console.ReadLine());

        Console.Write("Digite los días trabajados: ");
        empleado.DiasTrabajados=int.Parse(Console.ReadLine());

        empleado.InformacionPersona();
        await empleado.LeerSalarioAsync();
    }
}




 
 
 
 
 
 
 
 
 
 
 
 