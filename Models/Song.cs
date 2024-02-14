using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MusicApi.Attributes;

namespace MusicApi.Models;

public class Song
{
    // Unik identifierare
    public int Id { get; set; }

    // Egenskap för artist
    [Required]
    public string? Artist { get; set; }

    // Egenskap för titel
    [Required]
    public string? Title { get; set; }

    // Egenskap för längd (sekunder)
    public int Length { get; set; }

    // Främmandenyckel för att hålla reda på vilken kategori låten tillhör
    [CategoryExists]
    public int CategoryId { get; set; }

    // Navigationsegenskap
    [JsonIgnore]
    public Category? Category { get; set; }
}