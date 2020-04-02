using System;

namespace Refatoracao_loja_de_musica
{
    class FindGuitarTester
    {
        static void Main(string[] args)
        {
            //Configura estoque de guitarras
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("123ABC456CDF", 2000.0, "Fender", "Stratosfera", "SuperStrato", "Jacarandá", "Rosewood");
            Guitar guitar = inventory.Search(whatErinLikes);

            if (guitar != null)
                Console.WriteLine($"Erin, talvez você goste desta: \n {guitar.ToString()}");
            else
                Console.WriteLine("Desculpe Erin, não temos nada pra você");
        }

        private static void InitializeInventory(Inventory inventory)
        {
            //adiciona guitarras
            Guitar guitarra = new Guitar("123ABC456CDF", 2000.0, "Fender", "Stratocaster", "SuperStrato", "Jacarandá", "Rosewood");
            inventory.AddGuitar(guitarra);
            Guitar guitarra2 = new Guitar("123ABC4as56CDF", 2000.0, "Gibson", "Telecaster", "SuperStrato", "Mogno", "Rosewood");
            inventory.AddGuitar(guitarra2);
            Guitar guitarra3 = new Guitar("123AB2asC456CDF", 2000.0, "Tagima", "Stratocaster", "SuperStrato", "Jacarandá", "Rosewood");
            inventory.AddGuitar(guitarra3);
            Guitar guitarra4 = new Guitar("123asABC456CDF", 2000.0, "Giannini", "Stratocaster", "SuperStrato", "Jacarandá", "Rosewood");
            inventory.AddGuitar(guitarra4);
            Guitar guitarra5 = new Guitar("123ABC45sd6CDF", 2000.0, "Ibanez", "SuperStrato", "SuperStrato", "Rosewood", "Rosewood");
            inventory.AddGuitar(guitarra5);
            Guitar guitarra6 = new Guitar("123ABCasd456CDF", 2000.0, "Cort", "LEs PAul", "SuperStrato", "Jacarandá", "Rosewood");
            inventory.AddGuitar(guitarra6);
            Guitar guitarra7 = new Guitar("123ABC4asd56CDF", 2000.0, "ABC", "CDF", "SuperStrato", "Jacarandá", "Rosewood");
            inventory.AddGuitar(guitarra7);
        }
    }
}
