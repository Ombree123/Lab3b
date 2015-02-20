using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3b
{
    class Vente
    {
        private Article article;

        private int quantite;

        public void ajouterArticleVendu(Article a)
        {
            article = a;
        }

        public void ajouterQuantiteVendue(int q)
        {
            if (q > 0)
                quantite = q;
            else
                Console.WriteLine("ERREUR valeur négative");
        }

        public float calculerValeurVente()
        {
            return (quantite*article.lireValeurArticle()); 
        }

        public string lireDescriptionVente()
        {
            return (quantite+" d'articles se sont vendu pour "+article.lireValeurArticle()+"$ chaques, pour un total de "+quantite*article.lireValeurArticle());
        }

    }
}
