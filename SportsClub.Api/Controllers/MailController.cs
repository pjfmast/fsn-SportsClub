using Microsoft.AspNetCore.Mvc;
using SportsClub.Api.Services;
using SportsClub.SharedModels.Dtos;

namespace SportsClub.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class MailController(IMailService mail) : ControllerBase
{
    [HttpPost("sendmail")]
    public async Task<IActionResult> SendMailAsync(MailData mailData)
    {
        bool result = await mail.SendAsync(mailData, new CancellationToken());

        if (result)
        {
            return StatusCode(StatusCodes.Status200OK, "Mail has successfully been sent.");
        }
        else
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occured. The Mail could not be sent.");
        }
    }
}