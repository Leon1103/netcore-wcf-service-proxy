﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WcfProxy.Models;

namespace WcfProxy.Interfaces
{
    public interface ICountryServiceWrapper
    {
        IEnumerable<Country> GetCountries();
        Task<IEnumerable<Country>> GetCountriesAsync();
        void SaveCountry(Country country);
        Task SaveCountryAsync(Country country);
        void Clear();
        Task ClearAsync();
    }
}
