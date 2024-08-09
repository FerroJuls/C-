using D;

public class Program
{
    public static void Main()
    {
        IRepositorio repositorio = new RepositorioSQL();
        Servicio servicio = new Servicio(repositorio);

        servicio.ProcesarDatos("Datos importantes");
    }
}