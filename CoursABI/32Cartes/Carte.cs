using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartes
{
    public class Carte
    {
        private Valeur valeur;
        private Atout atout;
        private bool visible;

        public Valeur Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        public Atout Atout
        {
            get { return atout; }
            set { atout = value; }
        }

        public bool Visible
        {
            get { return visible; }
            set { visible = value; }
        }

        public Carte(Valeur valeur, Atout atout)
        {
            this.valeur = valeur;
            this.atout = atout;
            this.visible = false;
        }

        public void Tourne()
        {
            this.visible = !this.visible;
        }
        
        public override string ToString()
        {
            string rep = "********";
            if (this.visible)
            {
                rep="/" + valeur + "/" + atout;
            }
            return rep;
        }
    }

    public enum Valeur :int {
        SEPT=7, HUIT, NEUF, DIX, VALET, DAME, ROI, AS, Size=8
    }

    public enum Atout :int
    {
        PIQUE, COEUR, CARREAU, TREFLE, Size=4
    }



}
