using SportsClub.SharedModels.Dtos;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace SportsClub.Web.Services;

public class ScheduleService : IScheduleService
{
    private readonly HttpClient httpClient;

    public ScheduleService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<IEnumerable<LessonDto>> GetTodaysLessons()
    {
        IEnumerable<LessonDto> lessons = Enumerable.Empty<LessonDto>();

        try
        {
            // https://localhost:7263/api/Schedule/GetTodaysLessons
            var result = await httpClient.GetFromJsonAsync<IEnumerable<LessonDto>>("api/Schedule/GetTodaysLessons");
            lessons = result ?? Enumerable.Empty<LessonDto>();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"There was a problem loading lesson data: {ex.Message}");
        }

        return lessons;
    }
}