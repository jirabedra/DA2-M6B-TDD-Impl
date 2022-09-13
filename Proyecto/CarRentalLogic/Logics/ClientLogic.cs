using CarRentalLogicInterface.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalLogic.Logics
{
    public class ClientLogic : IClientLogic
    {
        public List<Client> Clients { get; set; } = new List<Client>
        {
            new Client{Name = "Juan", Country = "Uruguay", Active = true},
            new Client{Name = "Seba", Country = "Uruguay", Active = false},
            new Client{Name = "Fran", Country = "Argentina", Active = true},
        };

        public List<Client> GetClientsByNameAndCountry(string name, string country)
        {
            var found = Clients.Where(c => (c.Name == name && c.Country == country)).ToList();
            return found;
        }
    }
}
