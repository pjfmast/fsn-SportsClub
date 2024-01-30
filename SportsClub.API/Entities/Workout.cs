namespace SportsClub.API.Entities;

public class Workout
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }
    public string? Image { get; set; }

    // Duration in minutes:
    public int Duration { get; set; }
    public decimal? Price { get; set; }
}
