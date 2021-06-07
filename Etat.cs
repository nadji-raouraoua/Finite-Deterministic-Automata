using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Theorie_des_langages
{
    class Etat
    {
        string lettre = "Q";
        public Etat(string n)
        {
            this.lettre = n;
        }
        String get_lettre()
        {
            return this.lettre;
        }
    }
    
}
