using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque
{
    internal class CompteEpargne : Compte
    {
        private double tauxInteret = 0.03; // Taux d'intérêt par défaut de 3%

        // Méthode pour calculer et ajouter les intérêts
        public void AjouterInteret()
        {
            double interet = Solde * tauxInteret;
            Solde += interet;
            Console.WriteLine($"Intérêts ajoutés : {interet}. Nouveau solde : {Solde}");
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Type : Compte Épargne, Taux d'Intérêt : {tauxInteret * 100}%");
        }
    }
}
