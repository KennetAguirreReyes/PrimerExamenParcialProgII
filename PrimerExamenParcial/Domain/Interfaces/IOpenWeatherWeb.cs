using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOpenWeatherWeb
    {
        Task<WeatherForeCast.ForeCastInfo>
        GetWeatherByGeo(double x, double y, long dt);
        Task<List<Coordenadas>>
        GetLastLong(string City);
    }
}
