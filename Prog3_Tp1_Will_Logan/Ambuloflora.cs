using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
    internal class Ambuloflora : Plante,IBougeable
    {
        public int vitesse { get; set; }
        public Ambuloflora(int position_X, int position_Y, string nom, int vitesse ) : base(position_X, position_Y, nom)
        {
            this.vitesse = vitesse;
        }

        void IBougeable.Bouger(Organisme o, int deplacement_X, int deplacement_Y)
        {
            if(deplacement_X % 3 != deplacement_X)
            {
                o.position_X += deplacement_X - (deplacement_X % 3);
            }
            else
            {
                o.position_X += deplacement_X;
            }
            if (deplacement_Y % 3 != deplacement_Y)
            {
                o.position_Y += deplacement_Y - (deplacement_Y % 3);
            }
            else
            {
                o.position_Y += deplacement_Y;
            }

        }
    }
}
