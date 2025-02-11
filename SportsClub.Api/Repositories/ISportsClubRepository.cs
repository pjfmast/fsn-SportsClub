using SportsClub.Api.Entities;

namespace SportsClub.Api.Repositories;

public interface ISportsClubRepository
{
    Task<IEnumerable<Location>> GetLocations();
    Task<IEnumerable<Workout>> GetWorkouts();
    Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime);
}