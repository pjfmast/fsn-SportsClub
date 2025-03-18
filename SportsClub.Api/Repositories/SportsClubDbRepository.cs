using Microsoft.EntityFrameworkCore;
using SportsClub.Api.Data;
using SportsClub.Api.Entities;

namespace SportsClub.Api.Repositories;

public class SportsClubDbRepository(SportsClubDbContext sportsClubDbContext) : ISportsClubRepository
{
    public async Task<IEnumerable<Location>> GetLocations()
    {
        return await sportsClubDbContext.Locations.ToListAsync();
    }

    public async Task<IEnumerable<Workout>> GetWorkouts()
    {
        return await sportsClubDbContext.Workouts.ToListAsync();
    }

    public async Task<Workout?> GetWorkoutById(int id)
    {
        return await sportsClubDbContext.Workouts.FindAsync(id);
    }

    public async Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime)
    {
        var found = new List<Lesson>();
        found = await sportsClubDbContext.Lessons
            .Where((Lesson w) => w.StartDateTime >= startDateTime && w.StartDateTime <= endDateTime)
            .ToListAsync();

        return found;
    }

    public async Task AddWorkout(Workout workout)
    {
        await sportsClubDbContext.Workouts.AddAsync(workout);
        await sportsClubDbContext.SaveChangesAsync();
    }

}
