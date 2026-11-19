using University_Explorer_Portal.Models;

namespace University_Explorer_Portal.Services;

public class StudentApplicationService
{

    private readonly HttpClient _httpClient;

    public StudentApplicationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }


    public async Task<List<StudentApplication>> GetStudentsApplicationAsync()
    {
        var students = await _httpClient.GetFromJsonAsync<List<StudentApplication>>("/api/studentapplication");

        return students ?? new List<StudentApplication>();
    }

    public async Task PostStudentsApplicationAsync(StudentApplication Application)
    {
        var application = await _httpClient.PostAsJsonAsync("/api/studentapplication", Application);
        application.EnsureSuccessStatusCode();

    }
    
}