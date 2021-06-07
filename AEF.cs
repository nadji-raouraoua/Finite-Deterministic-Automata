using System;
using System.Collections.Generic;
using System.Drawing;
using static TP_Theorie_des_langages.Etat;

namespace TP_Theorie_des_langages
{
    internal class AEF
    {
        private int IntEtats;
        

        private List<string> Alphabet = new(); // initialise une liste ou l'on va mettre notre alphabet
        private List<Etat> Q = new List<Etat>(); // initialise la liste qui va contenir les etats
        public object[,] matrice;

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
                Q.Add(new Etat($"Q{ i }"));
            }
        }

         public void AffichageMatrice()
        {
            Rectangle R = new Rectangle();
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

         public void RemplissageMatrice()
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
            string lettre;
            int nb;
            //On demande a l'utilisateur de remplir les regles de transitions
            for (int i = 1; i < Q.Count; i++)
            {
                
                    Console.WriteLine($"L'etat {Q[i]} reconnait combien de lettres ?");
                    nb = Console.Read();

                    if (nb == 0)
                { 
                   // matrice[i, j] = "-";
                }
                    else if (nb == 1)
                    {
                        Console.Write($"Quel est la lettre que reconnais l'etat {Q[i]} ? : ");
                        lettre = Console.ReadLine();
                        
                        

                    while (!Alphabet.Contains(lettre))
                        {
                            Console.WriteLine("Cette lettre ne fais pas partie du language, veuillez reessayer");
                            lettre = Console.ReadLine();
                        }
                        Console.Write($"Vers Quel Etat Transitionne l'etat {Q[i]} ? : ");
                    Etat etat = new(Console.ReadLine());
                    while (!Q.Contains(etat))
                    {
                        Console.WriteLine("Cet etat ne fais pas partie de la liste des etats, veuillez reessayer");
                        etat = new(Console.ReadLine());
                    }


                }
                    else if ((nb == 2) || (nb > 2))
                    {
                        Console.WriteLine($"Quels sont les lettres que reconnait l'etat {Q[i]} ? :");
                        lettre = Console.ReadLine();
                        /// on mets LES ETATS VERS LESQUELS ON VA DANS LES CELLULES ET NON PAS LES LETTRES
                        
                    }
                        
                    
                    /// TODO: tracer un tableau pouvoir visualiser optimiser le remplissage des transitions
                    /// TODO: ne pas oublier le cas ou un etat possede plusieurs transitions
                    /// trouver un moyen de reconnaitre les differents etat ( peut-etre en utilisant le tokenizer pour separer les etats)
                    /// ne pas oublier de demander aussi a l'utilisateur d'entrer les etats finaux du AEF
                    /// aussi ne pas oublier d'implementer les boucles
                    /// creer une fonction qui gere les etats finaux ( et le cas de boucles dans l'etat finit)
                    /// creer une variable curseur qui se positionne sur les etats pour reconnaitre si un etat est un etat fini ( et permet de creer la condition d'arret)
                
            }
        }
      /*  public object ParcoursMatrice(object o)
        {
            for (int i = 0; i < Q.Count; i++)
            {
                for (int j = 0; j < Alphabet.Count; j++)
                {
                    
                }

            }
            return //matrice[i, j];
        }*/
         public void Transitions(Etat EtatDepart, string Lettre, Etat EtatFinal) 
            // represente la fonction Sigma,
            // EX: Sigma(Q0,b,Q1) pour signifier la transition de l'etat Q0 a Q1 a la reconnaissance de la lettre b
        {
            //Verifie si les EtatInitial et EtatFinal font partie de la liste Q
            while (!Q.Contains( EtatDepart))
            {
                Console.Write($"\n{EtatDepart} ne fais pas partie des etats presents dans la liste, veuillez reentrer un etat valide : ");
                EtatDepart = new Etat(Console.ReadLine());
            }
            while (!Q.Contains(EtatFinal))
            {
                Console.Write($"\n{EtatFinal} ne fais pas partie des etats presents dans la liste, veuillez reentrer un etat valide : ");
                EtatFinal = new Etat(Console.ReadLine());
            }
            while (!Alphabet.Contains(Lettre))
            {
                Console.Write($"\n{Lettre} ne fais pas partie des Lettres presentes dans la liste, veuillez reentrer une lettre valide : ");

                Lettre = Console.ReadLine();
            }
            object curseur=EtatDepart;
            /// On passe au transitions
            /// TODO: ecrire la fonction sigma 22/05/2021
        }
    }
}