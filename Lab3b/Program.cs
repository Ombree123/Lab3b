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
            Console.WriteLine("Test Valeur : 1");
            articles.ajouterValeurArticle(1);

            //Test Valeur Article Negative
            Console.WriteLine("Test Valeur Negative");
            articles.ajouterValeurArticle(-1);

            //Lecture Valeur Article
            articles.lireDescriptionArticle();
            Console.ReadLine();

            




        }
    }
}
