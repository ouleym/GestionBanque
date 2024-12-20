using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque
{
    public class Compte
    {
        public int Id { get; set; }
        public string NumeroCompte { get; set; }
        public double Solde { get; set; }

        // Méthode virtuelle pour effectuer un dépôt
        public virtual void Depot(double montant)
        {
            if (montant > 0)
            {
                Solde += montant;
                Console.WriteLine($"Dépôt de {montant} effectué. Nouveau solde : {Solde}");
            }
            else
            {
                Console.WriteLine("Le montant doit être positif.");
            }
        }

        // Méthode virtuelle pour afficher les informations du compte
        public virtual void AfficherInfos()
        {
            Console.WriteLine($"ID: {Id}, Numéro de Compte: {NumeroCompte}, Solde: {Solde}");
        }
    }
}
