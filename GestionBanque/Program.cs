using System;
using System.Collections.Generic;

namespace GestionBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création de l'agence
            Console.WriteLine("=== Création de l'Agence ===");
            int agenceId = GetIntegerInput("Entrez l'ID de l'agence : ");
            string agenceCode = GetStringInput("Entrez le Code de l'agence : ");

            Agence agence = new Agence
            {
                Id = agenceId,
                Code = agenceCode
            };

            Console.WriteLine("\nAgence créée avec succès !\n");

            // Saisie des clients
            Console.WriteLine("=== Ajout des Clients ===");
            int nbClients = GetIntegerInput("Combien de clients souhaitez-vous ajouter ? ");

            for (int i = 0; i < nbClients; i++)
            {
                Console.WriteLine($"\nClient {i + 1}:");

                
                string clientPrenom = GetStringInput("Entrez le prénom du client : ");
                string clientNom = GetStringInput("Entrez le nom du client : ");
                string clientTel = GetStringInput("Entrez le téléphone du client : ");

               
                Client client = new Client
                {
                    Prenom = clientPrenom,
                    Nom = clientNom,
                    Tel = clientTel
                };

                
                agence.AjouterClient(client);
            }

            Console.WriteLine("\nTous les clients ont été ajoutés avec succès !\n");

            
            Console.WriteLine("=== Informations des Clients ===");
            agence.AfficherClients();

            Console.WriteLine("\nProgramme terminé. Merci !");
            Console.ReadLine();
        }

        // Méthodes utilitaires pour récupérer les entrées
            static int GetIntegerInput(string message)
            {
                int result;
                Console.Write(message);
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier.");
                    Console.Write(message);
                }
                return result;
            }

        
        static string GetStringInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
