using University_Explorer_Portal.Models;

namespace University_Explorer_Portal.Services;

public class UniversityService
{
    private readonly HttpClient _httpClient;
    
    //  Constructor
    public UniversityService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<University>> GetUniversityAsync()
    {
        var university = await _httpClient.GetFromJsonAsync<List<University>>("/search?country=Ireland");

        return university ?? new List<University>();
    }
    
}