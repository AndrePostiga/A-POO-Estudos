using System;
using System.Collections.Generic;
using System.Text;

namespace loja_de_musica_refatorado
{
    class Inventory
    {
        private LinkedList<Guitar> guitars;

        public Inventory()
        {
            guitars = new LinkedList<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
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
                if (guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public LinkedList<Guitar> Search(GuitarSpec searchSpec)
        {
            LinkedList<Guitar> matchingGuitars = new LinkedList<Guitar>();
            
            foreach (Guitar guitar in this.guitars)
            {
                GuitarSpec guitarSpec = guitar.Spec;
                if(searchSpec.Equals(guitarSpec))
                    matchingGuitars.AddLast(guitar);
            }
            return matchingGuitars;
        }
    }
}
