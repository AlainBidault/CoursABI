using Cartes;
using Jeu;
using Joueurs;
using Paquets;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("bonjour bonjour");
            Console.ReadKey();
            
            MemoryDessin partie = new MemoryDessin(4);
            partie.Add("Bernard");
            partie.Add("Michel");
            partie.Jouer();
            
            Memory32 partie1 = new Memory32();
            partie1.Add("Bernard");
            partie1.Jouer();
            PlusOuMoins partie2 = new PlusOuMoins();
            partie2.Jouer();
        }
    }
}
