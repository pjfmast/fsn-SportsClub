using SportsClub.API.Data;
using SportsClub.API.Entities;
using SportsClub.API.Repositories.Contracts;

namespace SportsClub.API.Repositories;

public class SportsClubInMemoryRepository : ISportsClubRepository
{
    public async Task<IEnumerable<Location>> GetLocations()
    {
        await Task.Delay(100);
        IEnumerable<Location> locations
            = SportClubSeedData.Locations;

        return locations;
    }

    public async Task<IEnumerable<Workout>> GetAllLessons()
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
