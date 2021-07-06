using System;
using System.Collections.Generic;
using static TP_Theorie_des_langages.AEF;

namespace TP_Theorie_des_langages
{
    class Program
    {
        static void Main(string[] args)
            
        {
            /// Additional features i would like to implement:
            /// - Log what happens in the project in a JSON or .txt file
            /// - Save l'Alphabet et les etat in a DataBase
            /// 
            AEF Automate = new();
            Console.WriteLine("Remplissage de la Matrice...");
            System.Threading.Thread.Sleep(5);
            Automate.RemplissageMatrice();
            Console.WriteLine("Affichage de la Matrice...");
            Automate.AffichageMatrice();
            Console.WriteLine("On Passe au transitions");



        }
    }
}
