using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.ExpressionAlgebrique
{
    public abstract class Operateur:ExpressionAlgebrique
    {
        protected List<ExpressionAlgebrique> arguments;

        public delegate int Operation(int a, int b);

        public List<ExpressionAlgebrique> Arguments { get => arguments; set => arguments = value; }

        public Operateur()
        {
            this.arguments = new List<ExpressionAlgebrique>();
        }

        public void Add(ExpressionAlgebrique eA)
        {
            this.arguments.Add(eA);
        }

        //public abstract override void Afficher();

        protected void AfficherAux(string operateur)
        {
            Console.Write("(");
            for (int i = 0; i < arguments.Count; i++)
            {
                arguments[i].Afficher();
                if (i < (arguments.Count - 1))
                {
                    Console.Write(" "+operateur+" ");
                }
            }
            Console.Write(")");
        }

        protected int EvaluerAux(Operation op, int elementNeutre)
        {
            int produit = elementNeutre;
            foreach (ExpressionAlgebrique eA in arguments)
            {
                produit = op(produit, eA.Evaluer());
            }
            return produit;
        }
    }
}
