using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
    class Creature : Organisme, IBougeable
    {
        public int vitesse { get; set; }


        public Creature(int vitesse, int position_X, int position_Y, string nom) : base(position_X, position_Y, nom)
        {
            this.vitesse = vitesse;
        }

        void IBougeable.Bouger(Organisme o, int deplacement_X, int deplacement_Y)
        {
            o.position_X += vitesse * deplacement_X;
            o.position_Y += vitesse * deplacement_Y;
        }
    }
}
