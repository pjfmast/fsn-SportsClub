using SportsClub.SharedModels.Dtos;

namespace SportsClub.Web.Services;

public interface IScheduleService
{
    Task<IEnumerable<LessonDto>> GetTodaysLessons();
}