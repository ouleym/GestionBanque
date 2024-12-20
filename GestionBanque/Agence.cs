using System;
using System.Collections.Generic;

namespace GestionBanque
{
    public class Agence
    {
        private int id = 1;
        public int Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }

        private List<Client> clients = new List<Client>();

        public void AjouterClient(Client client)
        {
            if (client != null)
            {
                client.Id = id++;
                clients.Add(client);
            }
        }

        public void AfficherClients()
        {
            if (clients.Count > 0)
            {
                foreach (var client in clients)
                {
                    Console.WriteLine($"ID: {client.Id}, Nom: {client.Nom}, Prénom: {client.Prenom}, Tel: {client.Tel}");
                }
            }
            else
            {
                Console.WriteLine("Aucun client dans cette agence.");
            }
        }

        public override string ToString()
        {
            return $"Agence ID: {Id}, Code: {Code}, Libellé: {Libelle}";
        }
    }
}
