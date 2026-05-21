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
            return "Surfam na: " + url;
        }
        else
        {
            return "Neispravan url!";
        }

    }
    public string Poziv(string telefonski_broj)
    {
        if (ProvjeriAkoJeValidanBroj(telefonski_broj))
        {
            Console.Beep();
            return "Evoo zovem.... +" + telefonski_broj;
        }
        else
        {
            return "Neispravan telefonski broj!";
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
