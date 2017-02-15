
/* Vous revoila! Vous devez avoir fini "FormationNeo_Chapitre6_Structures_Exo1"...
 * 
 * Continuons par la structures conditionelles switch
 * Les notions dont vous avez besoin sont:
 *      --> Les variables
 *      --> La logique de Boole
 * 
 * Commencer par choisir ce projet au démarrage. pour ce faire, faites un clic droit sur "FormationNeo_Chapitre6_Structures_Solut2",
 * et cliquer sur l'icone de roue dentée "Définir comme projet de démarrage"
 * 
 * Utiliser Ctrl + F5 pour compiler et lancer le projet
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationNeo_Chapite6_Structures_Exo2
{
    class Exo2Ch6Solution
    {
        static void Main(string[] args)
        {
            /*  A vous de créer l'intégralité du code de cet exercice!
             *  Le QG des superhéros est une immense tour, il y a donc des ascenseurs!
             *  Créer une variable etage qui représente l'étage auquel on souhaite allez
             *  créer ensuite un switch (n'oublier pas de définir une valur par défaut)
             *  La tour fait 100 étages, 0 etant l'accueil!
             *  Une petite voix annonce le role de chaque étage:
                    Etage 0   -> Accueil
                    Etage 9   -> Armurerie
                    Etage 17  -> Salles de relaxation
                    Etage 21  -> Service informatique
                    Etage 23  -> Zoo et ménagerie
                    Etage 42  -> Salle de controle
                    Etage 50  -> Caféteria
                    Etage 68  -> Ressources Superhumaines
                    Etage 73  -> Système de défense nucléaire
                    Etage 100 -> Toit pour hélicoptère et étage panoramique
             * Tout les autres étages doivent être annoncés par "Bienvenue à l'étage X", où X est l'étage en question...
            */

            // Cette correction introduit une boucle for pour tester chaque solution possible
            // Elle n'était pas demandée, mais aide à tester le code ne manière exhaustive.
            for (int etage = 0; etage <= 100; etage++)
            {
                switch (etage)
                {
                    case 0:
                        Console.WriteLine("A cet étage : l'accueil");
                        break;

                    case 9:
                        Console.WriteLine("A cet étage : l'armurerie");
                        break;

                    case 17:
                        Console.WriteLine("A cet étage : les salles de relaxations");
                        break;

                    case 21:
                        Console.WriteLine("A cet étage : le service informatique");
                        break;

                    case 23:
                        Console.WriteLine("A cet étage : le zoo et la ménagerie");
                        break;

                    case 42:
                        Console.WriteLine("A cet étage : la salle de controle");
                        break;

                    case 50:
                        Console.WriteLine("A cet étage : la caféteria");
                        break;

                    case 68:
                        Console.WriteLine("A cet étage : les ressources superhumaines");
                        break;

                    case 73:
                        Console.WriteLine("A cet étage : le système de défense nucléraire");
                        break;

                    case 100:
                        Console.WriteLine("A cet étage : le toit pour hélicoptère et étage panoramique");
                        break;

                    default:
                        Console.WriteLine("Bienvenue à l'étage " + etage);
                        break;
                }
            }
        }
    }
}
