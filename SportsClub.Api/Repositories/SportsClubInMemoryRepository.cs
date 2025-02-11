using SportsClub.Api.Data;
using SportsClub.Api.Entities;

namespace SportsClub.Api.Repositories;


public class SportsClubInMemoryRepository : ISportsClubRepository
{
    public async Task<IEnumerable<Location>> GetLocations()
    {
        // Simulate a delay:
        await Task.Delay(100);
        IEnumerable<Location> locations
            = SportClubSeedData.Locations;

        return locations;
    }

    public async Task<IEnumerable<Workout>> GetWorkouts()
    {
        await Task.Delay(100);

        return SportClubSeedData.Workouts;
    }

 
    public async Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime)
    {
        await Task.Delay(100);

        IEnumerable<Lesson> found
            = SportClubSeedData.Lessons
            .Where((Lesson w) => w.StartDateTime >= startDateTime && w.StartDateTime <= endDateTime);

        return found;
    }
}