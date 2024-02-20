public class Animal
{
    public string nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine(nombre + " está comiendo.");
    }
}

public class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine(nombre + " está ladrando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Perro miPerro = new Perro();
        miPerro.nombre = "Fido";
        miPerro.Comer();
        miPerro.Ladrar();
    }
}
