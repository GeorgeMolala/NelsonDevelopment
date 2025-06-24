using Microsoft.Extensions.DependencyInjection;
using NelsonDevelopment.DataLayer.DataRepository;
using NelsonDevelopment.DataLayer.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NelsonDevelopment.Services
{
    public static class AppServices
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddTransient<IDataProcessor, DataProcessor>();
            

            //service.AddTransient<IQualificationHelper, QualificationRepository>();
            //service.AddTransient<IAddressLinkHelper, AddressLinkRepository>();
            //service.AddTransient<IQualificationLinkHelper, QualificationLinkRepository>();

        }
    }
}
