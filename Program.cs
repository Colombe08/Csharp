using System;

namespace MyApp 
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string joueur1;
            string joueur2;
            int essai = 0;
            string MotaDeviner;

            Console.WriteLine("Les règles du jeu : ");

            Console.WriteLine("Deux joueurs essayent de deviner le mot de l'autre joueur. Le joueur qui trouve le mot marque 1 point,");
            Console.WriteLine("Si le joueur tente et rate 6 fois de deviner le mot alors l'adversaire gagne 1 points");
            Console.WriteLine("Pour deviner le mot, le joueur doit proposer une lettre à la fois");
            Console.WriteLine("Le premier joueur qui remporte 3 points gagne la partie \n");

            // Entrez le nom des joueurs
            Console.WriteLine("Nom du premier joueur ?");
            joueur1 = Console.ReadLine();
             
 
            Console.WriteLine("Nom second joueur ?");
            joueur2 = Console.ReadLine();

            Console.WriteLine(joueur1 + " ,veuillez entrer le mot sans le montrer à " + joueur2);
            MotaDeviner = Console.ReadLine();
            Console.Clear();

            do
            {
                Console.WriteLine(joueur2 + " , proposer une et une seule lettre :");
                lettre = Console.ReadLine();
            }
            while (Mots.Count() == 1 && lettre[0] >= 'A' && lettre[0] <= 'Z');
        }
        
    }
}

// TESTE MON JEU // 

namespace LePenduDeCoco
{
    public class Jeu
    {
        public lengh text { get; set;}

        public int lengh {get;}

        public Jeu(string text)
        {
            Text = text.ToUpper();
            Length = Text.Length;
        }

        public int GetIndexOf(char letter)
        {
            return Text.IndexOf(letter);
        }

        // Les règles du jeu //
        static void Main(string[] args)
        {
            string joueur1;
            string joueur2;
            int essai = 0;
            string MotaDeviner;

            Console.WriteLine("Les règles du jeu : ");

            Console.WriteLine("Deux joueurs essayent de deviner le mot de l'autre joueur. Le joueur qui trouve le mot marque 1 point,");
            Console.WriteLine("Si le joueur tente et rate 6 fois de deviner le mot alors l'adversaire gagne 1 points");
            Console.WriteLine("Pour deviner le mot, le joueur doit proposer une lettre à la fois");
            Console.WriteLine("Le premier joueur qui remporte 3 points gagne la partie \n");

            // Entrez le nom des joueurs
            Console.WriteLine("Nom du premier joueur ?");
            joueur1 = Console.ReadLine();
             
 
            Console.WriteLine("Nom second joueur ?");
            joueur2 = Console.ReadLine();

            Console.WriteLine(joueur1 + " ,veuillez entrer le mot sans le montrer à " + joueur2);
            MotaDeviner = Console.ReadLine();
            Console.Clear();

            do
            {
                Console.WriteLine(joueur2 + " , proposer une et une seule lettre :");
                lettre = Console.ReadLine();
            }
            while (Mots.Count() == 1 && lettre[0] >= 'A' && lettre[0] <= 'Z');
        }
        
        // On ajoute les propriétés //
        public class Conditions

        {
        // Représente les caractères trouvés par l'adversaire //
        public List<char> Deviner { get; }
        // Représente les caractères non trouvés par l'adversaire
        public List<char> Manquer { get; }
        // Liste de mot aléatoire ou notre programme va piocher
        public List<Word> Mots { get; }
        // Choisir le mot à deviner //
        public Word MotaDeviner { get; }
        // Je présise le nom maximum d'erreur //
        private int maxErrors { get; set; }

        // Cette classe me permet d'afficher les mots à deviner aléatoirement
        private Random rnd;
        // Me permet de savoir si le joueur a gagné ou non
        private bool isWin { get; set; }
        
        // Variable temporaire où on travaille, le joueur à déjà trouvé des lettres
        private string currentWordDeviner;


        // Nombre d'erreurs maximum autorisés pour le joueur//
        public Jeu(int maxErrors = 10)
        {
            rnd = new Random();
            this.maxErrors = maxErrors;

            // Nos 5 mots qui seront choisis aléatoirement //
            Mots = new List<Word>
            {
                new Word("Colombe"),
                new Word("Halloween"),
                new Word("Lune"),
                new Word("Isitech"),
                new Word("Ordinateur")
            };

            Deviner = new List<char>();
            Manquer = new List<char>();

            MotaDeviner = Mots[rnd.Next(0, Mots.Count)];

            Console.WriteLine("Le mot à deviner contient {0} lettres", MotaDeviner.Length);
            currentWordDeviner = PrintMotaDeviner();
        }
        }




    }
    
    
}