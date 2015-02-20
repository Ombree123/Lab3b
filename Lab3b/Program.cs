using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Article articles = new Article();

            //Nom Article
            Console.WriteLine("Test Nom Article");
            articles.ajouterNomArticle("nomArticle");

            //Test Valeur Article 1
            
            Console.WriteLine("\nTest Valeur : 0");
            articles.ajouterValeurArticle(0);

            Console.WriteLine("\nTest Valeur : 1");
            articles.ajouterValeurArticle(1);

            Console.WriteLine("\nTest Valeur : -1");
            articles.ajouterValeurArticle(-1);

            //Lecture Valeur Article
            Console.WriteLine("\nTest Lire Valeur Article");
            Console.WriteLine(articles.lireValeurArticle());

            //Lecture Description Article
            Console.WriteLine("\nLire Description Article");
            Console.WriteLine(articles.lireDescriptionArticle());
            Console.ReadLine();


            Vente vente = new Vente();

            //Ajouter Article Vendu
            Console.WriteLine("\nAjouter Article Vendu");
            vente.ajouterArticleVendu(articles);

            //Ajouter Quantite Vendu
            Console.WriteLine("\nAjouter Quantite Vendu : 10");
            vente.ajouterQuantiteVendue(10);

            Console.WriteLine("\nAjouter Quantite Vendu : 0");
            vente.ajouterQuantiteVendue(0);

            Console.WriteLine("\nAjouter Quantite Vendu : -5");
            vente.ajouterQuantiteVendue(-5);

            //Calculer Valeur Vente
            Console.WriteLine("\nCalculer Valeur Vente");
            Console.WriteLine("La valeur de la vente est" + vente.calculerValeurVente()+"$");

            //Lire Description Vente
            Console.WriteLine("\nLire Description Vente");
            Console.WriteLine(vente.lireDescriptionVente());
            

            




        }
    }
}
