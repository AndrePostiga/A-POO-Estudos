using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace loja_de_musica_refatorado
{
    class FindGuitarTester
    {

        
        static void Main(string[] args)
        {
            
            //Configura estoque de guitarras
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocaster", Type.ACOUSTIC, Wood.ADIRONDACK, Wood.BRAZILIAN_ROSEWOOD, 12);
            LinkedList<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

            if (matchingGuitars.Count != 0)
            {
                Console.WriteLine("Erin, talvez você goste destas guitarras:");
                foreach (Guitar guitar in matchingGuitars)
                {
                    Console.WriteLine(guitar.ToString());
                }
            }
            else
                Console.WriteLine("Desculpe Erin, não temos nada pra você");

            
        }

        private static void InitializeInventory(Inventory inventory)
        {
            //adiciona guitarras
            Guitar guitarra = new Guitar("123ABC456CDF", 2000.0, new GuitarSpec(Builder.FENDER, "Stratocaster", Type.ACOUSTIC, Wood.ADIRONDACK, Wood.BRAZILIAN_ROSEWOOD, 6));
            inventory.AddGuitar(guitarra);
            Guitar guitarra2 = new Guitar("123ABC4as56CDF", 1888.99, new GuitarSpec(Builder.FENDER, "Stratocaster", Type.ACOUSTIC, Wood.ADIRONDACK, Wood.BRAZILIAN_ROSEWOOD, 6));
            inventory.AddGuitar(guitarra2);
            Guitar guitarra3 = new Guitar("123AB2asC456CDF", 2000.0, new GuitarSpec(Builder.COLLINGS, "Stratocaster", Type.ACOUSTIC, Wood.ADIRONDACK, Wood.BRAZILIAN_ROSEWOOD, 6));
            inventory.AddGuitar(guitarra3);
            Guitar guitarra4 = new Guitar("123asABC456CDF", 2000.0, new GuitarSpec(Builder.COLLINGS, "Stratocaster", Type.ACOUSTIC, Wood.ADIRONDACK, Wood.BRAZILIAN_ROSEWOOD, 6));
            inventory.AddGuitar(guitarra4);
            Guitar guitarra5 = new Guitar("123ABC45sd6CDF", 2000.0, new GuitarSpec(Builder.COLLINGS, "SuperStrato", Type.ACOUSTIC, Wood.ADIRONDACK, Wood.BRAZILIAN_ROSEWOOD, 6));
            inventory.AddGuitar(guitarra5);
            Guitar guitarra6 = new Guitar("123ABCasd456CDF", 1500.0, new GuitarSpec(Builder.FENDER, "Stratocaster", Type.ACOUSTIC, Wood.ADIRONDACK, Wood.BRAZILIAN_ROSEWOOD, 6));
            inventory.AddGuitar(guitarra6);
            Guitar guitarra7 = new Guitar("123ABC4asd56CDF", 2000.0, new GuitarSpec(Builder.COLLINGS, "CDF", Type.ACOUSTIC, Wood.ADIRONDACK, Wood.BRAZILIAN_ROSEWOOD, 6));
            inventory.AddGuitar(guitarra7);
        }
    }
}
