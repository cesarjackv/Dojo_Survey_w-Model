#pragma warning disable CS8618
namespace Dojo_Survey_w_Model.Models;
public class Survey
{
    public string Name { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Language { get; set; } = null!;
    public string? Message { get; set; } = null!;
}