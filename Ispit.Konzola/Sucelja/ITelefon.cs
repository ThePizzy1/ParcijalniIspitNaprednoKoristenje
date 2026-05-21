using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit.Konzola.Sucelja;

internal interface ITelefon
{
    public string Model { get;}
    public string Poziv(string telefonski_broj);
}
