using System;

namespace GestionBanque
{
    public class CompteSimple : Compte
    {
        public double Solde { get; set; }
        public string NumeroCompte { get; set; }


        // Afficher les informations du compte simple
        public override void AfficherInfos()
        {
            Console.WriteLine($"Compte {NumeroCompte} ");
            Console.WriteLine($"Solde : {Solde} €");
        }

        // Effectuer un dépôt sur le compte
        public void Depot(double montant)
        {
            if (montant > 0)
            {
                Solde += montant;
                Console.WriteLine($"Dépôt de {montant} € effectué. Nouveau solde : {Solde} €.");
            }
            else
            {
                Console.WriteLine("Le montant du dépôt doit être positif.");
            }
        }

        // Effectuer un retrait du compte
        public void Retrait(double montant)
        {
            if (montant > 0)
            {
                if (montant <= Solde)
                {
                    Solde -= montant;
                    Console.WriteLine($"Retrait de {montant} € effectué. Nouveau solde : {Solde} €.");
                }
                else
                {
                    Console.WriteLine("Solde insuffisant pour effectuer ce retrait.");
                }
            }
            else
            {
                Console.WriteLine("Le montant du retrait doit être positif.");
            }
        }
    }
}
