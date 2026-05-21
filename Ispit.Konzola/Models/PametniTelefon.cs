using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit.Konzola.Sucelja;

internal class PametniTelefon : IPametniTelefon
{
    public string Model { get; private set; }

    public PametniTelefon(string model)
    {
        if (string.IsNullOrWhiteSpace(model))
            throw new Exception("Model ne smije biti prazan!");
        Model = model;
    }
   

 public string Surfanje(string url)
    {
        if (ProvjeriAkoJeValidanUrl(url))
        {
            string poruka = "Surfam na: " + url;
            Console.WriteLine(poruka);
            return poruka;
        }
        else
        {
            string poruka = "Neispravan url!";
            Console.WriteLine(poruka);
            return poruka;
        }

    }
    public string Poziv(string telefonski_broj)
    {
        if (ProvjeriAkoJeValidanBroj(telefonski_broj))
        {
            string poruka = "Evoo zovem.... " + telefonski_broj;
            Console.Beep();
            Console.WriteLine(poruka);
            return poruka;
        }
        else
        {
            string poruka = "Neispravan telefonski broj!";
            Console.WriteLine(poruka);
            return poruka;
        }
    }

    public bool ProvjeriAkoJeValidanUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
            return false;
        

        foreach (char c in url)
        {
            if (char.IsDigit(c))
                return false;
            
        }

        return true;
    }

    public bool ProvjeriAkoJeValidanBroj(string broj)
    {
        if (string.IsNullOrWhiteSpace(broj))
            return false;
        

        foreach (char c in broj)
        {
            if (!char.IsDigit(c))
            return false;
        }

        return true;
    }
}
