using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalLogicInterface.Interfaces
{
    public interface IClientLogic 
    {
        public List<Client> GetClientsByNameAndCountry(string name, string country);
    }
}
