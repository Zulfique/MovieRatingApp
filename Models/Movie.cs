using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.Models;

public class Movie
{
    public int MovieId { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;

    [Range(1888, 2100)]
    [Display(Name = "Release Year")]
    public int ReleaseYear { get; set; }

    [Range(0, 10)]
    public double Rating { get; set; }
}
