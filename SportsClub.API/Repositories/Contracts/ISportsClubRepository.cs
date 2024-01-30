using SportsClub.API.Entities;

namespace SportsClub.API.Repositories.Contracts;

public interface ISportsClubRepository
{
    Task<IEnumerable<Location>> GetLocations();
    Task<IEnumerable<Workout>> GetAllLessons();
    Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime);
}
