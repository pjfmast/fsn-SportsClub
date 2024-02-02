using Microsoft.AspNetCore.Mvc;
using SportsClub.API.Extensions;
using SportsClub.API.Repositories.Contracts;
using SportsClub.Models.Dtos;

namespace SportsClub.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ScheduleController(ISportsClubRepository workoutRepository) : ControllerBase // Controller extends ControllerBase with support for Views
{

    [HttpGet]
    [Route(nameof(GetWorkouts))]
    public async Task<ActionResult<IEnumerable<WorkoutDto>>> GetWorkouts()
    {
        try
        {
            var workouts = await workoutRepository.GetAllWorkouts();

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
    [Route(nameof(GetAllLessons))]
    public async Task<ActionResult<IEnumerable<WorkoutDto>>> GetAllLessons()
    {
        try
        {
            var workouts = await workoutRepository.GetAllWorkouts();

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
        var workouts = await workoutRepository.GetAllWorkouts();

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
