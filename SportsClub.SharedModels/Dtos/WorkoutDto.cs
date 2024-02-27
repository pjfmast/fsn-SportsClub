using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace SportsClub.Models.Dtos;

// beste practice: use C#9 records for DTO's.
// see: https://stackoverflow.com/questions/64816714/when-to-use-record-vs-class-vs-struct
// for working with record type: https://www.infoworld.com/article/3607372/how-to-work-with-record-types-in-csharp-9.html

// BUT: Blazor model binding and validation is not supported (yet)
//     when using a record-type, see: https://github.com/dotnet/aspnetcore/issues/31604
public class WorkoutDto
{

    public int Id { get; set; }

    [StringLength(15, MinimumLength = 3, ErrorMessage = "Title length should be between 3 and 15 characters")]
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "";
    public string? Image { get; set; }
    public int Duration { get; set; }
    public decimal? Price { get; set; }
    //, List<String> Instructors
}

public class WorkoutValidator : AbstractValidator<WorkoutDto>
{
    public WorkoutValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Please enter a workout title");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter a description");
        RuleFor(x => x.Category).NotEmpty().WithMessage("Please enter a category");
        RuleFor(x => x.Duration).GreaterThan(0).WithMessage("Please enter a duration > 0");
        RuleFor(x => x.Price).GreaterThanOrEqualTo(0).WithMessage("Please enter a valid price");
        //RuleForEach(x => x.Route).SetValidator(new RouteInstructionValidator());
    }
}
