using CarRentalLogic.Logics;
using CarRentalLogicInterface;
using CarRentalLogicInterface.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceFactory.Factory
{
    public static class ServiceExtension
    {
        public static void RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICarLogic, CarLogic>();
            serviceCollection.AddScoped<IClientLogic, ClientLogic>();
            serviceCollection.AddScoped<IPlateLogic, PlateLogic>();
        }
    }
}
