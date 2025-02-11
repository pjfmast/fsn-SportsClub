namespace SportsClub.Api.Entities;

public class Lesson
{
    // of public int LessonId {get; set;}
    public int Id { get; set; }
    public int WorkOutId { get; set; }
    public int LocationId { get; set; }

    public required string Instructor { get; set; }
    public DateTime StartDateTime { get; set; }

}