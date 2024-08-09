using L;

public class Program
{
    public static void Main()
    {
        Animal[] animales = { new Perro(), new Gato() };

        foreach (var animal in animales)
        {
            animal.HacerSonido();
        }
    }
}