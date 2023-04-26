public class Program
{
    public static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        cachorro.EmitirSom(); // Saída: "Au au!"

        Gato gato = new Gato();
        gato.EmitirSom(); // Saída: "Miau!"

        Papagaio papagaio = new Papagaio();
        papagaio.EmitirSom(); // Saída: "Squawk!"
    }
}