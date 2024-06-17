// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

double continuar;
do
{

    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Bienvenido a la calculadora ficha:2694667");
Console.WriteLine("Seleccione la operación desea realizar digitando el numero:");
Console.WriteLine("+ = Suma");
Console.WriteLine("- = Resta");
Console.WriteLine("* = Multiplicación");
Console.WriteLine("/ = Division");
Console.WriteLine("% = Porcentaje");
Console.WriteLine("# = Promedio");
    Console.WriteLine("----------------------------------------");
    string operacion = Console.ReadLine();
Console.WriteLine("Ingrese el primer numero:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero:");
double num2 = double.Parse(Console.ReadLine());
double resultado = 0;
string nombreOperacion;
switch (operacion)
{
    case "+":
        resultado = num1 + num2;
        nombreOperacion = "Suma";
        break;
    case "-":
        resultado = num1 - num2;
        nombreOperacion = "Resta";
        break;
    case "*":
        resultado = num1 * num2;
        nombreOperacion = "Multiplicación";
        break;
    case "/":
        if (num2 != 0)
        {
            resultado = num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return;
        }
        nombreOperacion = "Division";
        break;
    case "%":
        resultado = (num1 * num2)/100;
        nombreOperacion = "Porcentaje";
        break;
    case "#":
        Console.WriteLine("Ingrese el tercer numero:");
        double num3 = double.Parse(Console.ReadLine());
        resultado = (num1 + num2 + num3)/3;
        nombreOperacion = "Promedio";
        break;
    default:
        Console.WriteLine("Operación no válida.");
        return;
}


Console.WriteLine("El resultado de la "+ nombreOperacion +" realizada es: " + resultado);


    Console.WriteLine("----------------------------------------");

    Console.WriteLine("Quieres hacer otra operación:");
    Console.WriteLine("1 = SI");
    Console.WriteLine("Digita cualquier letra = NO");
    continuar = double.Parse(Console.ReadLine());
} while (continuar == 1);
    
