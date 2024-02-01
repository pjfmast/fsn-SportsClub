using SportsClub.API.Entities;

namespace SportsClub.API.Repositories.Contracts;

public interface ISportsClubRepository
{
    Task<IEnumerable<Location>> GetLocations();
    Task<IEnumerable<Workout>> GetAllWorkouts();
    Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime);
}
