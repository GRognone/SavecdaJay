using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCountries
{
    public class C_Country
    {
        int countryId;
        public int CountryId { get => countryId; set => countryId = value; }
        string countrycode;
        public string CountryCode { get => countrycode; set => countrycode = value; }
        string countryName;
        public string CountryName { get => countryName; set => countryName = value; }

/// <summary>
/// Constructeur classic
/// </summary>
/// <param name=""></param>
/// <param name="_countryCode"></param>
/// <param name="_countryName"></param>
        public C_Country(string _countryCode ,string _countryName)
        {
            countrycode = _countryCode;
            countryName = _countryName;
        }
        /// <summary>
        /// Constructeur Classic
        /// </summary>
        /// <param name="_countryId"></param>
        public C_Country(int _countryId)
        {
            countryId = _countryId;
        }
    }
}


