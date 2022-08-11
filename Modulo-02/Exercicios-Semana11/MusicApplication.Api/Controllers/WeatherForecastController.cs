using Microsoft.AspNetCore.Mvc;

namespace MusicApplication.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    

    
    [HttpGet]
    public ActionResult Get()
    {
        return Ok();
    }
}
