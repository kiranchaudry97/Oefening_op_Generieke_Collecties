using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_op_Generieke_Collecties
{
    public class Persoon
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Persoon(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return $"{Naam} ({Leeftijd} jaar)";
        }
    }
}