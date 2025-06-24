using NelsonDevelopment.DataLayer.Helper_Classes;
using NelsonDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NelsonDevelopment.DataLayer.DataRepository
{
    public class DataProcessor : IDataProcessor
    {

      
        public async Task<SortedData> GetProcessedData(string Data)
        {
            if (string.IsNullOrWhiteSpace(Data))
            {

                throw new ArgumentException("Input cannot be null or empty");
            }

             

            var sortedWord =  Data
                .OrderBy(c => c)
                .Select(c => c.ToString())
                .ToArray();


            return await Task.FromResult(new SortedData(sortedWord));
        }
    }
}
