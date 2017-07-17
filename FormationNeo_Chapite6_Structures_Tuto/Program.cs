
/* Bonjour dans le second tutoriel de la formation Néo!
 * Les variables n'ont plus aucun secret pour vous? Bien, allons-y!
 * 
 * Même en ayant une idée des briques élémentaires qui composent votre programme, 
 * nous n'allons pas reconstruire le QG des héros avec si peu!
 * Ce projet est lui aussi à lire de haut en bas, comme un livre
 * Les commentaires (en vert, comme celui-çi) sont pour l'instant ce qui est 
 * le plus important à lire et à comprendre !
 * 
 * Il vous faut plus de puissance! Et pour cela, nous allons utiliser des
 * outils indispensable à la réalisation d'un programme informatique,
 * les structures de controles!
 * 
 * Nous verrons dans ce projet les structures conditionnelles, puis les boucles.
*/

using System;

namespace FormationNeo_Chapite6_Structures_Tuto
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Il y a de très très très nombreux exemple de structures de controles dans ce tutoriel!
             * Prennez votre temps pour comprendre et modifier les valeurs que vous voyez, soyer sûr 
             * d'être capable de retracer mentalement le chemin parcouru dans les boucles et branches
             * des structures de controles que vous allez voir. 
             * L'affichage étant très long, n'hésiter pas à mettre la fenètre de sortie en plein ecran,
             * et d'utiliser la molette de votre souris pour afficher tout les résultats!
            */

            // Les structures conditionnelles permettes des traitements spécifiques à réaliser dans un cadre précis
            // Par exemple, comment afficher une phrase à l'utilisateur en fonction de son age?
            #region Structures conditionnelles simple (if)
            Console.WriteLine("- - - Structures Simple - - -" + '\n');
            int monAge = 16;
            bool estUnHero = false;

            // Commençons par une structure simple, un simple if
            if (monAge == 16) // Si 'monAge' est strictement égal à 16
            {
                Console.WriteLine("J'ai 16 ans!");
            }
            // Notez bien le DOUBLE EGAL qui test l'égalité, contrairement au simple égal qui affecte une valeur!!!

            // Si une condition est fausse, alors tout le bloc en dessous ne s'affiche pas
            if (monAge <= 0) // Si 'monAge' est inférieur ou égal à 0
            {
                Console.WriteLine("Cette instruction ne s'affichera jamais, car la condition de test est fausse!");
            }

            // Il est possible d'écrire une condition simple sans accolades si elle tiens en une ligne
            if (true)
                Console.WriteLine("Cette phrase s'affichera toujours.");

            // Il est possible d'imbriquer les structures de controle
            if (monAge == 16)
            {
                if (estUnHero == false)
                {
                    Console.WriteLine("J'ai 16 ans et je ne suis pas un héro...");
                }
            }

            // Ce qui revient à écrire 
            if (monAge == 16)
                if (estUnHero == false)
                    Console.WriteLine("J'ai 16 ans et je ne suis pas un héro... Et la on a du mal à lire");
            // Attention à bien aérer votre code pour le garder lisible!

            // Finalement, vous trouverez peut être les accolades ainsi:
            if (estUnHero == true) {
                Console.WriteLine("On ne va pas afficher trop de lignes, hein?");
            }
            // Choisissez les accolades qu'il vous plait tant que c'est lisible!

            /* Petit rappel des compatateur d'égalité
             * == strictement égal
             * >  strictement supérieur
             * >= supérieur ou égal
             * <  strictement inférieur
             * <= inférieur ou égal
             * != différent de
            */

            if (monAge != 19)
            {
                Console.WriteLine("Je n'ai pas 19 ans");
            }

            // Enfin dans le cas des booléen, il est possible de tester directement l'égalité sans ajouter == true:
            estUnHero = true;
            if (estUnHero)
            {
                Console.WriteLine("Cette condition est vrai");
            }

            // On peut aussi tester la non égalité tout aussi simplement, grace à l'opérateur '!'
            if (!estUnHero)
            {
                Console.WriteLine("Je ne suis pas un héro"); // cette condition est fausse
            }
            #endregion

            #region Structures conditionnelles complexes (if / else if / else)
            Console.WriteLine('\n' + "- - - Structures Complexes - - -" + '\n');
            // Utilisons une structure plus complexe : le 'if / else if / else'
            // Littéralement, le 'si / sinon si / sinon'

            monAge = 25;

            if (monAge >= 40) // Si condition A
            {
                Console.WriteLine("J'ai plus de 40 ans et toutes mes dents!");
            }
            else if (monAge > 21) // Sinon condition B
            {
                Console.WriteLine("J'ai plus de 21 ans! A moi LasVegas!!!");
            }
            else if (monAge > 16) // Sinon condition C
            {
                Console.WriteLine("Je plus de 16 ans !");
            }
            else // Sinon "autre chose"
            {
                Console.WriteLine("Je ai moins de 16 ans...");
            }
            // Vous remarquerez que seule la condition B à été réalisée. (et pas la condition C)
            // En effet, dès qu'une condition est vrai, on quitte la structure de controle!

            // On peut effectuer toute les opérations que l'on veut dans une structure de controle
            if (monAge > 18)
                estUnHero = true;
            else
                estUnHero = false;
            Console.WriteLine("Valeur de 'estUnHero': " + estUnHero);
            #endregion

            #region Structures à conditions multiples
            Console.WriteLine('\n' + "- - - Structures à Conditions Multiples - - -" + '\n');
            // Que ce passe t-il quand on veux tester plusieurs variables en même temps? Et bien c'est possible!
            // Vous vous rappelez de la logique de Boole? (chapitre 4-1 sinon) Il est temps de la mettre en application!
            // Le "AND" devient "&&"
            // Le "OR" devient "||"
            // Le "NOT" devient '!'
            // Petite mise en application expliquée:
            bool a = false;
            bool b = true;
            bool c = true;

            if (a && b) // Si 'a' et 'b', donc si 'vrai' et 'faux', donc faux
            {
                // Cette proposition est fausse
                Console.WriteLine("Il aurai fallu que les deux conditions soient vrai pour afficher cette phrase...");
            }

            if (b || c) // si 'b' ou 'c', donc si 'vrai' ou 'vrai', donc vrai
            {
                // Cette proposition est vraie
                Console.WriteLine("Ces deux propositions sont vraies, donc cette phrase s'affiche!");
            }

            if (!a) // Si 'non a', donc si 'non faux', donc vrai
            {
                // Cette proposition est vraie
                Console.WriteLine("C'est vrai que c'est pratique la logique de Boole!");
            }

            if (a || (b && c)) // Si 'a' ou ('b' et 'c'), donc si 'faux' ou ('vrai' et 'vrai'), donc si 'faux' ou 'vrai', donc vrai
            {
                // Cette proposition est vraie
                Console.WriteLine("C'est complexe la non?");
            }

            // Bien évidement, la structure if / else if / else fonctionne avec cette logique
            if (a)
            {
                // Cette proposition est fausse
                Console.WriteLine("A est vrai");
            }
            else
            {
                // Cette proposition est vraie
                Console.WriteLine("A est fausse!");
            }


            // Si vous êtes perdu c'est un peu normal, c'est plus simple avec une application pratique:
            bool avoirFaim = true;
            bool frigoRempli = false;
            bool restoOuvert = true;

            if (avoirFaim)
            {
                if (frigoRempli)
                {
                    Console.WriteLine("J'ai faim et mon frigo est rempli, je vais pouvoir me faire à manger!");
                }
                else if (restoOuvert)
                {
                    Console.WriteLine("J'ai faim et mon frigo est vide, mais je connais un bon resto ouvert!");
                }
                else
                {
                    Console.WriteLine("Je vais probablement mourrir de faim!");
                }
            }
            else
            {
                Console.WriteLine("J'ai n'ai pas faim!");
            }
            // Je vous invite à jouer avec les 3 booléens de cet exemple pour afficher chaque phrase de cet exemple!

            #endregion


            // Si les conditions font parti intégrantes de tout language informatique, cette notion est indisociable de la
            // notion de boucle. Une boucle permet à une instruction d'être executé 'n' fois
            #region Les boucles (while)
            Console.WriteLine('\n' + "- - - Boucle While - - -" + '\n');
            // La boucle while permet de réaliser une opération donnée tant qu'une opération est vraie
            int index = 0;

            while (index < 5)
            {
                Console.WriteLine("Index While = " + index);
                index++;
            }
            // Cette boucle affiche les valeur comprises etre 0 et... 4! En effet, dès qu'index vaut 5, on sort
            // de la boucle et les traitement de la boucle n'ont plus lieu!

            // Il est possible d'effectuer toute sortes d'opération dans une boucle!
            estUnHero = false;
            int energie = 100;
            while (!estUnHero)
            {
                if (energie == 1)
                {
                    Console.WriteLine("Je suis devenu un héro!");
                    estUnHero = true;
                    break;
                }
                energie = energie - 33;
                Console.WriteLine("Allez encore 100 pompes! Je veux être un héro!");
            }
            // Cette boucle à donc lieu 3 fois avant que la condition "energie == 1" ne soit vraie
            // Le "break" permet de sortir de la boucle même si la condition du while est toujours vraie.
            // N"hésitez pas à modifier cette boucle pour tester les limites de la boucle while!
            // Essayer de comprendre ce qui se passe quand on retire ou commente l'instruction 'break'.
            // Chercher à modifier cette boucle pour ne plus avoir besoin de cette instruction (break)


            // Attention à bien vérifier que vos boucles se terminent correctement!
            // Décommenter le code si dessous et compiler l'application, c'est le grand n'importe quoi!
            // int max = 0;
            // while (true)
            // {
            //     max = max + 100000;
            //     Console.WriteLine(max);
            // }
            // Cette boucle est une boucle infinie (tant que la condition est vraie, et elle le reste...)
            // Et la valeur de "max" ne fait vite plus sens, car on dépasse bien vite la valeur maximale d'un int!
            // Pour arréter le montre, faites un Ctrl + C! Ou cliquer sur la croix en haut à droite.
            // Il n'y a aucun risque pour votre ordinateur!
            // Tester cette boucle en retirant le "Console.WriteLine(max)"... Que ce passe t-il? Pourquoi?

            //Il est ausi possible de tester des conditions d'arret de boucle complexe
            monAge = 35;
            while (monAge <= 39 && estUnHero) // test de deux conditions en une!
            {
                monAge++;
                Console.WriteLine("J'ai " + monAge + " ans et je peut encore être un héro!!!");
            }
            Console.WriteLine("Je suis trop vieux pour tout ça...");
            #endregion

            #region Les boucles (for)
            Console.WriteLine('\n' + "- - - Boucle For - - -" + '\n');
            // La boucle for permet de faire tout ce que fait la boucle while, mais différement.
            // reprennons le même exemple que pour la boucle while:
            for (index = 0; index < 5; index++)
            {
                Console.WriteLine("Index For = " + index);
            }
            // L'affichage est strictement le même dans les deux cas, et l'index va lui aussi de 0 à 4.
            // Et si vous placez normalement vos point-virgules à la fin de chaque ligne d'instruction,
            // nous pouvons observer ici une structure différente...
            // La première partie de la commande est une affectation de valeur, ou une déclaration
            // La seconde partie est ma condition d'arrèt (comme dans une boucle while)
            // La dernière partie est juste mon incrémentation

            // Voici une série de boucles for un peu différentes:
            // L'affichage sera commenté pour gagner en lisibilité, n'hésiter pas à les décommenter.
            
            // 1- Avec une déclaration
            for (int id = 9; id < 12; id++)
            {
                // Cette boucle à lieu 3 fois.
                //Console.WriteLine("Index id = " + id);
            }

            // 2- Avec une décrémentation
            for (int valeur = 12; valeur > 9; valeur--)
            {
                // Cette boucle à lieu 3 fois.
                //Console.WriteLine("Index valeur = " + valeur);
            }

            // 3- Avec une incrémentation supérieur à 1
            for (int odd = 1; odd < 15; odd = odd + 2)
            {
                // Cette boucle à lieu 7 fois, et affiche uniquement des nombres impaires (odd en anglais)
                //Console.WriteLine("Index odd = " + odd);
            }

            // 4- Une boucle "infinie"
            int indexForInfini = 0;
            for (;;) // Cette boucle est similaire à while(true)
            {
                // Cette boucle à lieu 3 fois.
                indexForInfini++;
                Console.WriteLine("Index boucle for 'infinie' = " + indexForInfini);
                if (indexForInfini == 3)
                {
                    break;
                }
            }
            // Et cet exemple vous prouve qu'une boucle peut être infinie tant qu'il existe un moyen de l'arréter!

            // 5- Une boucle "infinie", version 2
            for ( ; indexForInfini < 5; )
            {
                // Cette boucle à lieu 2 fois.
                indexForInfini++; // indexForInfini est égal à 3 au démarrage de cette boucle
                Console.WriteLine("Index boucle for 'infinie' version 2 = " + indexForInfini);
            }
            // Cette syntaxe étrange prouve que l'on peut remplir un, deux ou trois champs de la boucle for
            // sans avoir d'erreur, tant que l'on place la bonne instruction au bon endroit.
            // cet exemple est plus pour votre curriosité personelle, car ce genre de boucle est très rare...
            #endregion
        }
    }
}
