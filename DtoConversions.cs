public static class DtoConversions
{
    public static Workout ToWorkout(this WorkoutDto workoutDto)
    {
        return new Workout
        {
            Title = workoutDto.Title,
            Description = workoutDto.Description,
            Category = workoutDto.Category,
            Image = workoutDto.Image,
            Duration = workoutDto.Duration,
            Price = workoutDto.Price
        };
    }
}
using SportsClub.Api.Helpers;

// POST: api/Workouts
// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
[HttpPost]
public async Task<ActionResult<Workout>> CreateWorkout(WorkoutDto workoutDto)
{
    var workout = workoutDto.ToWorkout();

    _context.Workouts.Add(workout);
    await _context.SaveChangesAsync();

    return CreatedAtAction("GetWorkout", new { id = workout.Id }, workout);
}
