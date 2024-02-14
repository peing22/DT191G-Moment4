using System.ComponentModel.DataAnnotations;
using MusicApi.Data;

namespace MusicApi.Attributes;

// Anpassat attribut för att validera CategoryId
public class CategoryExistsAttribute : ValidationAttribute
{
    // Metod för att utföra valideringen med IsValid-metoden från basklassen
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        // Hämtar databaskontext
        var dbContext = validationContext.GetRequiredService<MusicContext>();

        // Deklarerar categoryId med värde för value om value är av typen int
        if (value is int categoryId)
        {
            // Om categoryId är 0 returneras felmeddelande
            if (categoryId == 0)
            {
                return new ValidationResult("The CategoryId field is required.");
            }
            // Om det finns en kategori i databasen som motsvarar categoryId sätts categoryExists till true
            var categoryExists = dbContext.Categories.Any(c => c.Id == categoryId);

            // Om categoryExists är false returneras felmeddelande
            if (!categoryExists)
            {
                return new ValidationResult("Specified categoryId does not exist.");
            }
        }
        // Returnerar framgångsrik validering
        return ValidationResult.Success;
    }
}