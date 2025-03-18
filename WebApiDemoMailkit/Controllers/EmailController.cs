using Microsoft.AspNetCore.Mvc;

namespace WebApiDemoMailkit.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly IEmailService _emailService;

    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost]
    [Route("SendEmail")]
    public async Task<IActionResult> SendEmail(string toEmail, string mailSubject, string mailBody)
    {
        var result = await _emailService.SendEmail(toEmail, mailSubject, mailBody);
        return Ok(new { message = result });
    }
}