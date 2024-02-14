using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MusicApi.Models;

public class Category
{
    // Unik identifierare
    public int Id { get; set; }

    // Egenskap för namn
    [Required]
    public string? Name { get; set; }

    // Navigationsegenskap
    [JsonIgnore]
    public ICollection<Song>? Songs { get; set; }
}