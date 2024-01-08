/**
 * Jeu du nombre caché
 * auteur :moi mdr
 * date : 08/01/24
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = false;
            int valeur, essai, nbre = 1;
            valeur = 0;
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher : ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saissisez un nombre entier : ");
                }
            }
            Console.Clear();
            correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    while (essai != valeur)
                    {
                        if (essai > valeur)
                        {
                            Console.WriteLine(" --> Trop grand !");
                        }
                        else
                        {
                            Console.WriteLine(" --> Trop petit !");
                        }
                        nbre++;
                        Console.Write("Entrez un essai = ");
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saissisez un nombre entier : ");
                }
            }
            
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
            Console.ReadLine();
        }
    }
}
