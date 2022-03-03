
public class Program
{
    public static void Main(String[] args)
    {
        var generadorAleatorio = new Random();
        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);

        Console.WriteLine("Tiene 3 intentos");

        Console.WriteLine($"El numero a adivinar era {numeroParaAdivinar}"); 

    } 

}

