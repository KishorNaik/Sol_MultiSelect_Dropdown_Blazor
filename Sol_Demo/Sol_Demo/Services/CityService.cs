using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Services
{
    public interface ICityService
    {
        Task<IEnumerable<CityModel>> GetCityDataAsync();
    }

    public class CityService : ICityService
    {
        Task<IEnumerable<CityModel>> ICityService.GetCityDataAsync()
        {
            var cityList = new List<CityModel>();
            cityList.Add(new CityModel()
            {
                Id = 1,
                CityName = "Mumbai"
            });
            cityList.Add(new CityModel()
            {
                Id = 2,
                CityName = "Delhi"
            });
            cityList.Add(new CityModel()
            {
                Id = 3,
                CityName = "Chennai"
            });
            cityList.Add(new CityModel()
            {
                Id = 4,
                CityName = "Kolkatta"
            });

            return Task.FromResult<IEnumerable<CityModel>>(cityList);
        }
    }
}
