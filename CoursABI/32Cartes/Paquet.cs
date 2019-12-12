using cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoursABI._32Cartes
{
    public class Paquet
    {
        // Patron de Concept / Design Pattern : façade
        private List<Carte> cartes;
        private static int NBR_CARTES = (int)Valeur.Size * (int)Atout.Size;

        public List<Carte> Cartes
        {
            get { return cartes; }
            set { cartes = value; }
        }

        public Paquet()
        {
            cartes = new List<Carte>(NBR_CARTES);
            for (int i = 0; i < (int) Valeur.Size; i++)
            {
                for (int j = 0; j < (int) Atout.Size; j++)
                {
                    cartes.Add(new Carte((Valeur)i+7, (Atout)j));
                }
            }

        }

        public Carte Get(int i)
        {
            // permet Paquet p1; p1.Get(5) plutôt que p1.Cartes[5]
            return this.cartes[i];
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            Carte cSauv;
            for (int i = 0; i < cartes.Count; i++)
            {
                int k = rnd.Next(cartes.Count);
                cSauv = cartes[i];
                cartes[i] = cartes[k];
                cartes[k] = cSauv;
            }
        }
        
        public override string ToString()
        {
            string rep = "";
            for (int i = 0; i < cartes.Count; i++)
            {
                rep += cartes[i]+"\n";
            }
            return rep;
        }
    }
}
