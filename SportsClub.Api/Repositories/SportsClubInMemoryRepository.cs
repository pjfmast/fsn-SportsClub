using SportsClub.Api.Data;
using SportsClub.Api.Entities;

namespace SportsClub.Api.Repositories;


public class SportsClubInMemoryRepository : ISportsClubRepository
{
    private readonly List<Workout> _workouts = new List<Workout>(SportClubSeedData.Workouts);

    public async Task<IEnumerable<Location>> GetLocations()
    {
        // Simulate a delay:
        await Task.Delay(100);
        IEnumerable<Location> locations = SportClubSeedData.Locations;

        return locations;
    }

    public async Task<IEnumerable<Workout>> GetWorkouts()
    {
        await Task.Delay(100);
        return _workouts;
    }

    public async Task<Workout?> GetWorkoutById(int id)
    {
        await Task.Delay(100);
        return _workouts.Find(w => w.Id == id);
    }

    public async Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime)
    {
        await Task.Delay(100);
        IEnumerable<Lesson> found = SportClubSeedData.Lessons
            .Where((Lesson w) => w.StartDateTime >= startDateTime && w.StartDateTime <= endDateTime);
        return found;
    }

    public async Task AddWorkout(Workout workout)
    {
        // Simulate a delay:
        await Task.Delay(100);
        _workouts.Add(workout);
    }
}