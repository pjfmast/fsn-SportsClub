namespace SportsClub.API.Entities;

public class Location
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Address { get; set; }
    public int Capacity { get; set; }
    public bool IsOutside { get; set; } = false;

}
