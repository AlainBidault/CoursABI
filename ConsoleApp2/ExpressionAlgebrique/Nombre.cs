using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.ExpressionAlgebrique
{
    public class Nombre:ExpressionAlgebrique
    {
        public int Valeur
        {
            get;
            set;
        }

        public Nombre(int valeur)
        {
            this.Valeur = valeur;
        }

        public override void Afficher()
        {
            Console.Write(Valeur);
        }

        public override int Evaluer()
        {
            return Valeur;
        }

        public string EnChaine()
        {
            return Valeur+"";
        }

    }
}
