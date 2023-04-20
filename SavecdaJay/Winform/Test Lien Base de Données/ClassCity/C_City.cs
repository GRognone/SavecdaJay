using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCity
{
   public class C_City
    {
        int cityId;
        public int CityId { get => cityId; set => cityId = value; }
        string cityName;
        public string CityName { get => cityName; set => cityName = value; }
        string countryCode;
        public string CountryCode { get => countryCode; set => countryCode = value; }
       
        /// <summary>
        /// Constructeur Classic
        /// </summary>
        /// <param name="_cityId"></param>
        /// <param name="_cityName"></param>
        public C_City(string _cityName, string _countryCode)
        {
            cityName = _cityName;
            CountryCode = _countryCode;
        }
        /// <summary>
        /// Constructeur Classic
        /// </summary>
        /// <param name="_cityId"></param>
        public C_City(int _cityId)
        {
            cityId = _cityId;
        }
    }
}
