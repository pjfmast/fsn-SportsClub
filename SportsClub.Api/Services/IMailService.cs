using SportsClub.SharedModels.Dtos;

namespace SportsClub.Api.Services;

public interface IMailService
{
    Task<bool> SendAsync(MailData mailData, CancellationToken ct);
}