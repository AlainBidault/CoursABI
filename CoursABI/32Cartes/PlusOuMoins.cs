using cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursABI._32Cartes
{
    class PlusOuMoins
    {
        public void Jouer()
        {
            Paquet paquet = new Paquet();
            paquet.Shuffle();
            Console.WriteLine("le paquet" + paquet);
            Carte c0 = paquet.Get(0);
            c0.Tourne();
            Carte c1 = paquet.Get(1);
            Console.WriteLine("plus ou moins ?" + c0);
            string rep = Console.ReadLine();
            c1.Tourne();
            if ((rep.Equals("+") && (c1.Valeur >= c0.Valeur)) || (rep.Equals("-") && (c1.Valeur <= c0.Valeur)))
            {
                Console.WriteLine("Bravo !" + c1);
            }
            else
            {
                Console.WriteLine("Perdu !" + c1);
            }
            Console.ReadKey();
        }
    }
}
