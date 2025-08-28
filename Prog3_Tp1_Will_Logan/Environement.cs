using System;
using System.Collections.Generic;
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
    }
}
