using Microsoft.EntityFrameworkCore;
using SportsClub.API.Data;
using SportsClub.API.Entities;
using SportsClub.API.Repositories.Contracts;

namespace SportsClub.API.Repositories
{
    public class SportsClubDbRepository : ISportsClubRepository
    {
        private readonly SportsClubDbContext sportsClubDbContext;

        public SportsClubDbRepository(SportsClubDbContext sportsClubDbContext)
        {
            this.sportsClubDbContext = sportsClubDbContext;
        }
        public async Task<IEnumerable<Location>> GetLocations()
        {
            return await sportsClubDbContext.Locations.ToListAsync();
        }

        public async Task<IEnumerable<Workout>> GetAllWorkouts()
        {
            return await sportsClubDbContext.workouts.ToListAsync();
        }

        public async Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime)
        {
            var found = new List<Lesson>();
            found = await sportsClubDbContext.lessons
                .Where((Lesson w) => w.StartDateTime >= startDateTime && w.StartDateTime <= endDateTime)
                .ToListAsync();

            return found;
        }
    }
}
