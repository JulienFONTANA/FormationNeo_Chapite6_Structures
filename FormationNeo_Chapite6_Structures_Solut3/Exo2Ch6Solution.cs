
/* Vous revoila! Vous devez avoir fini "FormationNeo_Chapitre6_Structures_Exo2"...
 * 
 * Comme les structures conditionelles n'ont plus aucun secret pour vous, passons au boucles!
 * Les notions dont vous avez besoin sont:
 *      --> Les variables
 *      --> Les structures conditionnelles
 *      --> La logique de Boole
 * 
 * Commencer par choisir ce projet au démarrage. pour ce faire, faites un clic droit sur "FormationNeo_Chapitre6_Structures_Solut3",
 * et cliquer sur l'icone de roue dentée "Définir comme projet de démarrage"
 * 
 * Utiliser Ctrl + F5 pour compiler et lancer le projet
*/

using System;

namespace FormationNeo_Chapite6_Structures_Solution2
{
    class Exo2Ch6Solution
    {
        static void Main(string[] args)
        {
            // Faites une boucle FOR qui affiche tout le nombres divisibles par 7 entre 1 et 100
            // Solution N°1 - On parcours et test tout les nombres divisibles par 7
            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Solution N°2 - On utilise les propriétés de la boucle for pour n'afficher que les nombres divisible par 7
            //for (int i = 7; i < 100; i = i + 7)
            //{
            //    Console.WriteLine(i);
            //}

            // Faites une boucle WHILE infinie qui test l'égalité entre deux int 'a' et 'b' entre 0 et 50000
            //  ayant 'a' < 'b' et qui incrémente 'a' jusqu'a ce que les deux valeurs soient identiques.
            int a = 23007;
            int b = 36042;
            // Solution N°1 - Boucle infinie, on test l'égalité dans le traitement de la boucle
            while (true)
            {
                a++;
                if (a == b)
                {
                    break;
                }
            }
            Console.WriteLine("Valeurs de a: " + a);

            // Solution N°2 - On boucle simplement jusqu'à obtenir l'égalité entre 'a' et 'b'
            a = 23007;
            while (a < b)
            {
                a++;
            }
            Console.WriteLine("Valeurs de a: " + a);

            // Faites la boucle de votre choix qui divise par 2 un nombre entier 'n' supérieur à 1000000
            // jusqu'a ce que 'n' soit inférieur ou égal à 100.
            // Afficher le nombre de division nécessaires!
            int n = 1234123;
            int nbDivisions = 0;

            // Solution N°1 - Une boucle while
            while (n >= 100)
            {
                n = n / 2;
                nbDivisions++;
            }
            Console.WriteLine("Nombres de divisions: " + nbDivisions);

            // Solution N°2 - Une boucle for
            nbDivisions = 0;
            for (n = 1234123; n >= 100; nbDivisions++)
            {
                n /= 2;
            }
            Console.WriteLine("Nombres de divisions: " + nbDivisions);
        }
    }
}
