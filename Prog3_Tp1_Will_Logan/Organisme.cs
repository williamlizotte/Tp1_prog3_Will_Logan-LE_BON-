using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
    public abstract class Organisme
    {
        public int position_X { get; set; }
        public int position_Y { get; set; }
        public string nom { get; set; }
        public Organisme(int position_X, int position_Y, string nom)
        {
            this.position_X = position_X;
            this.position_Y = position_Y;
            this.nom = nom;
        }


    }
}
