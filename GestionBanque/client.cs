using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GestionBanque
{
    public class Client
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Tel { get; set; }

        // Liste des comptes associés au client
        public List<Compte> Comptes { get; set; } = new List<Compte>();

        // Méthode pour ajouter un compte au client
        public void AjouterCompte(Compte compte)
        {
            if (compte != null)
            {
                Comptes.Add(compte); // Ajout du compte à la liste des comptes
                Console.WriteLine("Compte ajouté au client.");
            }
            else
            {
                Console.WriteLine("Erreur : Le compte est nul.");
            }
        }

        // Afficher les informations du client et de ses comptes
        public void AfficherInfos()
        {
            Console.WriteLine($"Client : {Prenom} {Nom}, Tel : {Tel}");
            foreach (var compte in Comptes)
            {
                compte.AfficherInfos(); // Afficher les informations de chaque compte
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nom: {Prenom} {Nom}, Tel: {Tel}";
        }
    }
}
