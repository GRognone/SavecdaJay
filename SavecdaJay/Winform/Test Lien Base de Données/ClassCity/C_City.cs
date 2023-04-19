using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCity
{
   public class ClassCity
    {
        int cityID;
        public int City { get => cityID; set => value; }
        string cityName;
        public string CityName { get => cityName; set => value; }

        /// <summary>
        /// Constructeur Classic
        /// </summary>
        /// <param name="_cityId"></param>
        /// <param name="_cityName"></param>
        public ClassCity(int _cityId, string _cityName)
        {
            cityID = _cityId;
            cityName = _cityName;
        }
    }
}
