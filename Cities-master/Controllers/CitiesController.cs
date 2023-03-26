using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CitiesController : ControllerBase
{
    private static readonly List<City> Cities = new List<City>
    {
        new City { Name = "Stockholm" },
        new City { Name = "G�teborg" },
        new City { Name = "Malm�" },
        new City { Name = "Uppsala" },
        new City { Name = "Link�ping" },
        new City { Name = "�rebro" },
        new City { Name = "V�ster�s" }
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
