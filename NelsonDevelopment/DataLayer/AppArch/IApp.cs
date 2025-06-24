using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NelsonDevelopment.DataLayer.AppArch
{
    public interface IApp<T> where T:class
    {
        Task<T> GetProcessedData(string Data);
    }
}
