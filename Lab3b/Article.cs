using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3b
{
    class Article
    {
        private string nom; 
        private float valeur;

        public void ajouterNomArticle (string n)
        {
            nom = n;
        }
        public void ajouterValeurArticle(float v)
        {
            if (v >= 0)
                valeur = v;
            else
                Console.WriteLine("ERREUR valeur négative");
        }

        public float lireValeurArticle()
        {
            return (valeur);
        }

        public string lireDescriptionArticle()
        {
            return ("Nom : "+nom+" Valeur : "+valeur);
        }


}
}
