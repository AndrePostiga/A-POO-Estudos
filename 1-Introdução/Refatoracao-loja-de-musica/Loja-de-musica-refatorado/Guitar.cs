using System;
using System.Collections.Generic;
using System.Text;


namespace loja_de_musica_refatorado
{
    class Guitar
    {
        
        public string SerialNumber { get; private set; }
        public double Price { get; set; }
        public GuitarSpec Spec { get; set; }
        

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Spec = spec;
        }

        public override string ToString()
        {
            return $"Guitarra de {this.Spec.NumStrings} cordas da {this.Spec.Builder.ToString()} {this.Spec.Model}, com corpo em {this.Spec.BackWood.ToString()} e tampo em {this.Spec.TopWood.ToString()}, custa a bagatela de ${this.Price}";
        }
    }

    class GuitarSpec
    {
        public Builder Builder { get; private set; }
        public string Model { get; private set; }
        public Type Type { get; private set; }
        public Wood BackWood { get; private set; }
        public Wood TopWood { get; private set; }
        public int NumStrings { get; private set; }

        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.NumStrings = numStrings;
        }

        public override bool Equals(object obj)
        {
            GuitarSpec guitarSpec = (GuitarSpec) obj;
            return (
                this.Builder == guitarSpec.Builder &&
                this.Model.ToLower() == guitarSpec.Model.ToLower() &&
                this.Type == guitarSpec.Type &&
                this.BackWood == guitarSpec.BackWood &&
                this.TopWood == guitarSpec.TopWood &&
                this.NumStrings == guitarSpec.NumStrings
            );
        }
    }
}
