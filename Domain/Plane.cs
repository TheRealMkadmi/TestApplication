using System.ComponentModel.DataAnnotations;

namespace Data;

public class Plane
{
    [Key] public string Id { get; set; }
    
    [Required] public string Name { get; set; }
}