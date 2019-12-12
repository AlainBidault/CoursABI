using CoursABI._32Cartes;
using CoursABI.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursABI
{
    using Carte = cartes.Carte;
    using CarteMemo= CoursABI.carte.memo.CarteMemo;
    using Symbole = CoursABI.carte.memo.Symbole;
    class Program
    {
        static void Main(string[] args)
        {
            //TestConsole();
            /*Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(System.DateTime.Now);
            System.Console.WriteLine(System.Environment.UserName);
            LireChaine();*/

            /** Sans classe abstraite 
            Carte carte1 = new Carte("bleue", 3);
            Console.WriteLine(carte1);
            Carte carte2 = new Carte();
            Console.WriteLine(carte2);
            
            Carte carte3 = new CarteMemo(Symbole.arbre, "jaune");
            Console.WriteLine(carte3);
            Carte carte4 = new CarteMemo();
            Console.WriteLine(carte4);
            Connexion.Update();
            Connexion.Query1();
            Console.WriteLine("---------------");
            Connexion.Query2();*/


            Console.WriteLine("Une valeur " + cartes.Valeur.DIX);
            Console.WriteLine("Une autre valeur " + (int) cartes.Valeur.HUIT);
            Console.WriteLine("Une valeur " + (int) cartes.Valeur.Size);
            PlusOuMoins partie= new PlusOuMoins();
            partie.Jouer();

        }        


        private static void LireChaine()
        {
            Console.WriteLine("Veuillez saisir une phrase et valider avec la touche \"Entrée\"");
            string saisie = Console.ReadLine();
            Console.WriteLine("Vous avez saisi : " + saisie);

            Console.WriteLine("Stop ou encore (E)");
            ConsoleKeyInfo touche = Console.ReadKey(true);
            if (touche.Key == ConsoleKey.E)
            {
                Console.WriteLine("On continue ...");
            }
            else
            {
                Console.WriteLine("On s'arrête ...");
            }

            bool ageIsValid = false;
            int age = -1;
            while (!ageIsValid)
            {
                Console.WriteLine("Veuillez saisir votre age");
                saisie = Console.ReadLine();
                if (int.TryParse(saisie, out age))
                    ageIsValid = true;
                else
                {
                    ageIsValid = false;
                    Console.WriteLine("L'age que vous avez saisi est incorrect ...");
                }
            }
            Console.WriteLine("Votre âge est de : " + age);

        }

        
        private static void TestConsole()
        {
            Console.WriteLine("coucou");
            int a = 18;
            if (a < 15)
                Console.WriteLine("MOINS");
            else
                Console.WriteLine("PLUS");

            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Console.WriteLine(jours);
            for (int i = 0; i < jours.Length; i++)
            {
                Console.WriteLine(jours[i]);
            }
            string[] jours2 = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Console.WriteLine(jours2);
            for (int i = 0; i < jours.Length; i++)
            {
                Console.WriteLine(jours2[i]);
            }

            List<string> lJours = new List<string> { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            // erreur List<string> lJours2 = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

            foreach (string jour in lJours)
            {
                Console.WriteLine(jour);
            }
        }



        public enum Jours2
        {
            Lundi = 5, // lundi vaut 5
            Mardi, // mardi vaut 6
            Mercredi = 9, // mercredi vaut 9
            Jeudi = 10, // jeudi vaut 10
            Vendredi, // vendredi vaut 11
            Samedi, // samedi vaut 12
            Dimanche = 20 // dimanche vaut 20
        }


    }
}
