
/* Vous revoila! Vous devez avoir lu "FormationNeo_Chapitre6_Structures_Tuto"...
 * Si ce n'est pas fait, cliquer dans l'onglet de droite "Explorateur de solution" sur le projet qui 
 * s'appel "FormationNeo_Chapitre5_Variable_Tuto". Dans le menu déroulant qui s'affiche, et double cliquer 
 * sur le fichier "Program.cs" pour continuer votre formation.
 * 
 * Nous allons commencer par les structures conditionelles (if, if/else if)
 * Les notions dont vous avez besoin sont:
 *      --> Les variables
 *      --> Le 'if / else if / else'
 *      --> le switch
 *      --> La logique de Boole
 * 
 * Commencer par choisir ce projet au démarrage. pour ce faire, faites un clic droit sur "FormationNeo_Chapitre6_Structures_Exo1",
 * et cliquer sur l'icone de roue dentée "Définir comme projet de démarrage"
 * 
 * Utiliser Ctrl + F5 pour compiler et lancer le projet
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationNeo_Chapite6_Structures_Exo1
{
    class Exo1Ch6
    {
        /* Nous allons créer un système d'identification pour savoir qui aura accès au QG des
         * super-héros, et pour cela nous allons tester notre système de défense.
         * C'est parti!
        */

        static void Main(string[] args)
        {
            // A vous de déclarer et de modifier les variables comme il vous plaira!
            bool hero = false;
            bool superhero = false;

            // Ce système est défaillante, il laisse rentrer n'importe qui!
            // Appliquer une modification pour que seul un héro puisse passer!
            if (true)
            {
                Console.WriteLine("Bonjour héro!");
            }
            else
            {
                Console.WriteLine("Seul un héro peut passer!"); // Il faut afficher cette ligne si un "non héro" essaye de rentrer
            }
            

            // La salle de controle possède le même système, mais plus complexe
            // Si les héros ont accès au batiment, seul un vrai superhéro doit avoir accès à
            // la salle de controle! Modifier ce code pour que cela soit exacte
            // On considère qu'un superhéro est un héro
            if (true)
            {
                // Encore une fois, seul un héro ou un superhéro doit pouvoir voir cette ligne
                Console.WriteLine("Bienvenue dans le QG, héro!");
                if (true)
                {
                    // Seul un superhéro doit voir cette ligne
                    Console.WriteLine("Bienvenue dans la salle de controle, superhéro!");
                }
                else
                {
                    // Cette ligne doit être afficher aux héros, mais ni au super héro, ni aux 'non héro'
                    Console.WriteLine("Désolé, salle réservé au super héros!");
                }
            }

            // Tout les jours, des centaines de nouvelles personnes tentent d'être accepté chez les superhéros!
            // Ces personnes sont évalués sur 3 critères : puissace, intelligence et vitesse, comprises entre 0 et 100
            // Si une personne n'as qu'un critère au dessus de 50, et que la somme de ces compétances est égale ou supérieure à 100, c'est un héro
            // Si toutes les valeurs sont supérieurs à 60, alors c'est un super héro
            // Enfin, si une des valeurs est égal à 100 et que la somme des critères est supérieur à 260, c'est surement Superman!
            // Tout les autres sont des civils!
            //
            // A vous d'écrire un code permettant de tester la valeur des nouvelles recrues!
            // Indice : Allez y pas à pas!
            // Pas besoin de dire à Superman que c'est un superhéro ni un héro...
            // Pas besoin de dire à un superhéro que c'est un héro non plus!
            int puissance = 0;
            int intelligence = 0;
            int vitesse = 0;

        }
    }
}
