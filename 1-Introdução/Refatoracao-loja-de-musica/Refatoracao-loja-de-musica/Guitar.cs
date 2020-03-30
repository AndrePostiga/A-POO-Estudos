using System;
using System.Collections.Generic;
using System.Text;

namespace Refatoracao_loja_de_musica
{
    class Guitar
    {
        public string serialNumber { get; private set; }
        public string builder { get; private set; }
        public string model { get; private set; }
        public string type { get; private set; }
        public string backWood { get; private set; }
        public string topWood { get; private set; }
        public double price { get; set; }

        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public override string ToString()
        {
            return $"Guitarra {this.builder} {this.model}, com corpo em {this.backWood} e tampo em {this.topWood}, custa a bagatela de ${this.price}";
        }
    }
}
