using CityInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI
{
    public class DataStore
    {

        public static DataStore Current { get; } = new DataStore();

        public DataStore()
        {
            Cities = new List<City>()
            {
            new City(){Id=1,Name ="New York", Description="The city with expensive taxis" },
            new City(){Id=2,Name ="Montana", Description="The city close to Canada" },
            new City(){Id=3,Name ="Calgary", Description="The cold city" },
            new City(){Id=4,Name ="Edmonton", Description="The colder city" }
            };
        }
        public List<City> Cities;
    };

}

