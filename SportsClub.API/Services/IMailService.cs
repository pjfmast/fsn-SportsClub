using SportsClub.SharedModels;

namespace SportsClub.API.Services
{
    public interface IMailService
    {
        Task<bool> SendAsync(MailData mailData, CancellationToken ct);
    }
}
