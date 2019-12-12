using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.ExpressionAlgebrique
{
    public class Addition: Operateur
    {
        public override void Afficher()
        {
            base.AfficherAux("+");
        }

        public override int Evaluer()
        {
            return base.EvaluerAux((a, b) => a + b,0);
        }
    }
}
