using System;
using musicStore;

namespace Refatoração_loja_de_musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Guitar guitarra = new Guitar("123ABC456CDF", 2000, "Fender", "Stratocaster", "SuperStrato", "Jacarandá", "Rosewood");
            Console.WriteLine(guitarra.ToString());
        }
    }
}
