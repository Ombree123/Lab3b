using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3b
{
    class Facture
    {
        private Vente[] ventes;

        public void ajouterArticleVendu(Vente v)
        {
            int i = 0;
            ventes[i] = v;
            i++;
        }

        private float calculerMontantFacture()
        {
            float montant=0;

            for (int i = 0; i < 100; i++)
			{
                montant += ventes[i].calculerValeurVente();
			}
            return (montant);
        }

        public string lireFacture()
        {
            return ("placeholder");
        }
    }
}
