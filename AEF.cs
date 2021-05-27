using System;
using System.Collections.Generic;

namespace TP_Theorie_des_langages
{
    internal class AEF
    {
        private int IntEtats;
        

        private List<string> Alphabet = new(); // initialise une liste ou l'on va mettre notre alphabet
        private List<string> Q = new List<string>(); // initialise la liste qui va contenir les etats
        public string[,] matrice;

        public AEF()
        {
            Console.WriteLine("Veuillez entrer l'alphabet de votre language");
            foreach (char c in Console.ReadLine())
            {
                string v = char.ToString(c);
                Alphabet.Add(v); //adds every letter of the alphabet to a list of strings
            }
            Console.WriteLine("Veuillez entrer le nombre d'etats");

            string StringEtats = Console.ReadLine();
            while (!int.TryParse(StringEtats, out IntEtats)) //checks if the entered string can be converted to an integer
            {
                Console.WriteLine("Ceci n'est pas un nombre, Veuillez reessayer");
                StringEtats = Console.ReadLine(); //Repete l'operation jusqu'a ce que l'on entre un chiffre valide
            }
            IntEtats = int.Parse(StringEtats); //Convertis la chaine de charactere en nombre
            for (int i = 0; i < IntEtats; i++)
            {
                Q.Add("Q" + i);
            }
        }

        private void AffichageMatrice()
        {
            for (int i = 0; i < Q.Count; i++)
            {
                for (int j = 0; j < Alphabet.Count; i++)
                {
                    //TODO: tracer un tableau pouvoir visualiser optimiser le remplissage des transitions
                    Console.Write(matrice[i, j]);
                }
                Console.Write("\n");
            }
        }

        private void RemplissageMatrice()
        {
            //initialisation de la matrice
            matrice = new string[Q.Count + 1, Alphabet.Count + 1];
            //affectation des valeurs a la matrice
            //remplissage des lignes
            matrice[0, 0] = "Matrice";
            for (int i = 1; i < Q.Count; i++)
            {
                matrice[i, 0] = Q[i];
            }
            //remplissage des colonnes
            for (int i = 1; i < Alphabet.Count; i++)
            {
                matrice[0, i] = Alphabet[i];
            }
            //On demande a l'utilisateur de remplir les regles de transitions
            for (int i = 1; i < Q.Count; i++)
            {
                for (int j = 1; j < Alphabet.Count; i++)
                {
                    Console.Write($"Quel est la lettre que reconnais l'etat {Q[i]} ? : ");
                    /// TODO: tracer un tableau pouvoir visualiser optimiser le remplissage des transitions
                    /// TODO: ne pas oublier le cas ou un etat possede plusieurs transitions
                    /// trouver un moyen de reconnaitre les differents etat ( peut-etre en utilisant le tokenizer pour separer les etats)
                    /// ne pas oublier de demander aussi a l'utilisateur d'entrer les etats finaux du AEF
                    /// aussi ne pas oublier d'implementer les boucles
                    /// creer une fonction qui gere les etats finaux ( et le cas de boucles dans l'etat finit)
                    /// creer une variable curseur qui se positionne sur les etats pour reconnaitre si un etat est un etat fini ( et permet de creer la condition d'arret)
                }
            }
        }

        private void Transitions(string EtatInitial, string Lettre, string EtatFinal)  // represente la fonction Sigma, EX: Sigma(Q0,b,Q1) pour signifier la transition de l'etat Q0 a Q1 a la reconnaissance de la lettre b
        {
            //Verifie si les EtatInitial et EtatFinal font partie de la liste Q
            while (!Q.Contains(EtatInitial))
            {
                Console.Write($"{EtatInitial} ne fais pas partie des etats presents dans la liste, veuillez reentrer un etat valide : ");
                EtatInitial = Console.ReadLine();
            }
            while (!Q.Contains(EtatFinal))
            {
                Console.Write($"{EtatFinal} ne fais pas partie des etats presents dans la liste, veuillez reentrer un etat valide : ");
                EtatFinal = Console.ReadLine();
            }
            while (!Alphabet.Contains(Lettre))
            {
                Console.Write($"{Lettre} ne fais pas partie des Lettres presentes dans la liste, veuillez reentrer une lettre valide : ");

                Lettre = Console.ReadLine();
            }
            var curseur = 0;
            /// On passe au transitions
            /// TODO: ecrire la fonction sigma 22/05/2021
        }
    }
}