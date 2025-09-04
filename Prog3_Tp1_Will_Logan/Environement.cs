using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
     class Environement<T> where T : Organisme
    {
        private List<T> _environements;

        public Environement()
        {
            _environements = new List<T>();
        }

        public void AjouterOrganisme(T e)
        {
            _environements.Add(e);
        }

        public Organisme TrouverPlusProche(Organisme o) //
        {
            int PetiteDistance = 0;
            int distance;
            int i = 1;
            string nomPlusProche;
            string nomActuelle;
            foreach (T e in _environements)
            {  
                distance = (o.position_X - e.position_X) ^ 2 + (o.position_Y - e.position_Y) ^ 2;
                nomActuelle = o.nom;
                
                if (i == 1 && o.nom == nomActuelle)
                {
                    i++;
                    PetiteDistance = distance;
                    nomPlusProche = nomActuelle;
                }
                else
                {
                    if(PetiteDistance > distance && o.nom == nomActuelle)
                    {
                        PetiteDistance = distance;
                        nomPlusProche = nomActuelle;
                    }
                }
            }
            return o;
        }
    }
}
