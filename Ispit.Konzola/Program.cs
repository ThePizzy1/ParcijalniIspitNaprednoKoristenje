using Ispit.Konzola.Sucelja;

namespace Ispit.Konzola;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Upiši koji telefon koristiš: ");
        PametniTelefon telefon = new PametniTelefon(Console.ReadLine());

        TestirajTelefon(telefon);
    }
    public static void TestirajTelefon(IPametniTelefon telefon)
    {
        Console.Write("Koji broj da zovem? ");
        string broj = Console.ReadLine();

        PametniTelefon konkretniTelefon = telefon as PametniTelefon;
         konkretniTelefon.Poziv(broj);
        

        Console.Write("Koju web stranicu da posjetim? ");
        string url = Console.ReadLine();

        telefon.Surfanje(url);
    }
}
