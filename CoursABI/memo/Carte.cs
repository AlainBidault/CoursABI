using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursABI.carte
{

    public interface ICarte
    {
        bool Compatible(Carte c2);
        void Retourne();
    }

    public abstract class Carte : ICarte
    {
        // Déclaration d'une propriété avec des accesseurs et mutateurs simples
        // La modification de cette propriété est protégée
        public bool Visible { get; protected set; }

        // Déclaration équivalente, avec l'attribut privé explicité
        protected string couleur;
        public string Couleur {get {return couleur;} protected set { couleur = value;}}

        public int Valeur { get; protected set; }

        // Constructeur avec des valeurs par défaut, bien choisir l'ordre de déclaration des paramètres
        public Carte(string couleur = "Rouge", int valeur = 1)
        {
            Visible = false;
            this.couleur = couleur;
            Valeur = valeur; // appel implicite au mutateur - set
        }

        public virtual bool Compatible(Carte c2)
        {
            return this.Couleur.Equals(c2.Couleur);
        }

        // Ecriture synthétique (avec un corps d'expression) de la méthode void qui met une carte sur son autre face.
        public void Retourne() => Visible = !Visible;

        // Redéfinition de la méthode ToSTring
        public override string ToString() => Valeur + Couleur;
    }
}
