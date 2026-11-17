using University_Explorer_Portal.Models;

namespace University_Explorer_Portal.Services;

public class CountryService
{
    private readonly HttpClient _httpClient;
    
    // Constructor
    public  CountryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Country>> GetCountriesAsync()
    {
        var country = await _httpClient.GetFromJsonAsync<List<Country>>("/countries");

        return country ?? new List<Country>();
    }

}