namespace SportsClub.SharedModels.Dtos;

// beste practice: use C#9 records for DTO's.
// see: https://stackoverflow.com/questions/64816714/when-to-use-record-vs-class-vs-struct
// for working with record type: https://www.infoworld.com/article/3607372/how-to-work-with-record-types-in-csharp-9.html

// BUT: Blazor model binding and validation is not supported (yet)
//     when using a record-type, see: https://github.com/dotnet/aspnetcore/issues/31604
public class WorkoutDto
{

    public int Id { get; set; }

    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "";
    public string? Image { get; set; }
    public int Duration { get; set; }
    public decimal? Price { get; set; }
}
