using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CitiesController : ControllerBase
{
    private static readonly List<City> Cities = new List<City>
    {
        new City { Name = "Stockholm" },
        new City { Name = "Göteborg" },
        new City { Name = "Malmö" },
        new City { Name = "Uppsala" },
        new City { Name = "Linköping" },
        new City { Name = "Örebro" },
        new City { Name = "Västerås" }
    };

    [HttpGet]
    public IEnumerable<City> Get(string search = "")
    {
        if (string.IsNullOrEmpty(search))
        {
            return Cities;
        }

        return Cities.Where(c => c.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
    }
}
