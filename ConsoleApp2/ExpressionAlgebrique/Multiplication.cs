using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.ExpressionAlgebrique
{
    class Multiplication : Operateur
    {
        
        public override void Afficher()
        {
            base.AfficherAux("x");
        }

        public override int Evaluer()
        {
           return base.EvaluerAux((a,b)=>a*b,1);
        }
    }
}
