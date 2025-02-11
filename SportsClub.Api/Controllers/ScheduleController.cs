using Microsoft.AspNetCore.Mvc;
using SportsClub.Api.Extensions;
using SportsClub.Api.Repositories;
using SportsClub.SharedModels.Dtos;

namespace SportsClub.Api.Controllers;


[ApiController]
[Route("api/[controller]")]

public class ScheduleController(ISportsClubRepository workoutRepository) : ControllerBase // Controller extends ControllerBase with support for Views
{
    [HttpGet]
    [Route(nameof(GetWorkouts))]
    public async Task<ActionResult<IEnumerable<WorkoutDto>>> GetWorkouts()
    {
        try
        {
            var workouts = await workoutRepository.GetWorkouts();

            if (workouts == null)
            {
                return NotFound();
            }
            else
            {
                var workoutDtos = workouts.ConvertToDto();

                return Ok(workoutDtos);
            }

        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                            "Error retrieving data from the database");

        }
    }



    [HttpGet]
    [Route(nameof(GetLessonsBetween))]
    public async Task<ActionResult<LessonDto>> GetLessonsBetween(DateTime dateStart, DateTime dateEnd)
    {
        var locations = await workoutRepository.GetLocations();
        var workouts = await workoutRepository.GetWorkouts();

        var lessonsFound = await workoutRepository.GetSchedule(dateStart, dateEnd);
        var lessenDtos = lessonsFound.ConvertToDto(locations, workouts);

        return Ok(lessenDtos);

    }

    [HttpGet]
    [Route(nameof(GetTodaysLessons))]
    public async Task<ActionResult<LessonDto>> GetTodaysLessons()
    {
        DateTime startOfDay = DateTime.Now.StartOfDay();
        DateTime endOfDay = DateTime.Now.EndOfDay();

        return await GetLessonsBetween(startOfDay, endOfDay);
    }

}