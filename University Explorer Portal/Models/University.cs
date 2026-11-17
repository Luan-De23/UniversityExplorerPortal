using System.Text.Json.Serialization;

namespace University_Explorer_Portal.Models;

public class University
{
    public string Name { get; set; }
    public string Country { get; set; }
    [JsonPropertyName("web_pages")] 
    public List<string> WebPages { get; set; } = new List<string>();
    public List<string> Domains { get; set; } = new List<string>();
    
}