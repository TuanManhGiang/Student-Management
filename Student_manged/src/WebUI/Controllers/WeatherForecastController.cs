using Microsoft.AspNetCore.Mvc;
using Student_manged.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace Student_manged.WebUI.Controllers;
public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}
