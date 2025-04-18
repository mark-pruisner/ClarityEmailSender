namespace EmailWebApp.Models;

public class EmailViewModel
{
    public string To { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string? StatusMessage { get; set; }
}
