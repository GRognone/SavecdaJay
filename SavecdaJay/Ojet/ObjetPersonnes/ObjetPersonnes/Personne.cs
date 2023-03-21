using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetPersonnes
{
    public abstract class Personne
    {
         int age;
        public void DanserDisco()
        {
        }
        public abstract void  DanserSalon();
        public virtual void  Marcher()
        {
        }
    }  
}






