using System;
using System.Collections.Generic;
using System.Text;

namespace Refatoracao_loja_de_musica
{
    class Inventory
    {
        private LinkedList<Guitar> guitars;

        public Inventory()
        {
            guitars = new LinkedList<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            guitars.AddLast(guitar);
        }

        public void AddGuitar(Guitar guitar)
        {
            guitars.AddLast(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {
                if (guitar.serialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public Guitar Search(Guitar searchGuitar)
        {
            foreach (Guitar guitar in guitars)
            {
                //ignorar o numero de serie e preço, não são relevantes pra pesquisa
                string builder = searchGuitar.builder;
                if (builder != null && !builder.Equals("") && !builder.Equals(guitar.builder))
                    continue;               

                string model = searchGuitar.model;
                if (model != null && !model.Equals("") && !model.Equals(guitar.model))
                    continue;                

                string type = searchGuitar.type;
                if (type != null && !type.Equals("") && !type.Equals(guitar.type))
                    continue;                

                string backWood = searchGuitar.backWood;
                if (backWood != null && !backWood.Equals("") && !backWood.Equals(guitar.backWood))
                    continue;

                string topWood = searchGuitar.topWood;
                if (topWood != null && !topWood.Equals("") && !topWood.Equals(guitar.topWood))
                    continue;

                return guitar;
            }
            return null;
        }
    }
}
