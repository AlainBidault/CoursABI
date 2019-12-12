using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursABI.carte.memo
{
    using Carte = CoursABI.carte.Carte;

    // La classe CarteMemo hérite de Carte
    public class CarteMemo : Carte
    {
        // Déclaration d'une propriété supplémentaire, l'enum Symbole est situé plus bas
        public Symbole Motif { get; private set; }

        // héritage du constructeur avec le mot clé base et des valeurs par défaut
        public CarteMemo(Symbole motif=Symbole.maison, string couleur = "Rouge", int valeur = 1) : base (couleur,valeur)
        {
            Motif = motif;
        }

        public override bool Compatible(Carte c)
        {
            CarteMemo c2 = (CarteMemo)c;
            return this.Couleur.Equals(c2.Couleur) &&
                this.Motif.Equals(c2.Motif);
        }

        // on complète la méthode ToString héritée
        public override string ToString()
        {
            return base.ToString()+Motif;
        }

    }

    public enum Symbole
    {
        maison, arbre, etoile, fanion, chat, lapin
    }
}
