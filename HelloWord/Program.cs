// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//calculadora

//se declara las variables 



//Console.WriteLine("Calculadora");
//Console.WriteLine("Escribe el primer numero");
//double numero1 = double.Parse(Console.ReadLine());

//Console.WriteLine("escribe el segundo numero:");
//double numero2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Escoge el tipo de operacion");
//Console.WriteLine("1 suma");
//Console.WriteLine("2 Resta");
//Console.WriteLine("3 Multiplicacion");
//Console.WriteLine("4 Division");

//switch (Console.ReadLine()) //muestra el menú.
//{
//    case "1":
//        Console.WriteLine($"Tu resultado es : {numero1} + {numero2} = " + (numero1 + numero2));
//        break;
//    case "2":
//        Console.WriteLine($"Tu resultado es: {numero1} - {numero2} = " + (numero1 - numero2));
//        break;
//    case "3":
//        Console.WriteLine($"Tu resultado es: {numero1} * {numero2} = " + (numero1 * numero2));
//        break;
//    case "4":
//        Console.WriteLine($"Tu resultado es {numero1} / {numero2} = " + (numero1 / numero2));
//        break;
//}
//Console.Write("presiona una tecla para cerrar la calculadora");
//Console.ReadKey();

// calculadora instructor 
Console.WriteLine("----Bienvenido a la calculadora----");

int opcion;
do {

    //menú
    Console.WriteLine("Escoge el tipo de operacion");
    Console.WriteLine("+ suma");
    Console.WriteLine("- resta");
    Console.WriteLine("* multiplicacion");
    Console.WriteLine("/ Division"); string operacion = Console.ReadLine();
    double resultado = 0;

    //Ingresar numeros 
    Console.WriteLine("Ingrese el primer numero:");
    double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero:");
double num2 = double.Parse(Console.ReadLine());





//operaciones

switch (operacion)
{
    case "+":
       Console.WriteLine($"El resultado de la suma es:{resultado = num1 + num2}") ;
        break;
    case "-":
        Console.WriteLine($"El resultado de la resta es:{resultado = num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"El resultaje de la multiplicacion es:{resultado = num1 * num2}");
        break;
    case "/":
        if (num2 != 0)
        {
            Console.WriteLine($"El resultaje de la multiplicacion es:{resultado = num1 / num2}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return;
        }
        break;
    case "%":
        Console.WriteLine($"el resultado del porcentaje");
        break;

    default:
        Console.WriteLine("Operación no válida.");
        return;
}



//Console.WriteLine("El resultado de la operación realizada es: " + resultado);