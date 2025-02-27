namespace UniversityKitchen.Excpetion;

public class ErrorView
{
    public string? RequestedId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestedId);
}