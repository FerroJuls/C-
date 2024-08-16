using System;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando Lectura de datos");
        Console.WriteLine("Esto se va a demorar 5 segundos");

        var resultado = await LeerBaseDatosSimulada();
        Console.WriteLine(resultado);
    }

    static async Task<string> LeerBaseDatosSimulada()
    {
        await Task.Delay(5000);
        return "Datos leídos correctamente";
    }
}
