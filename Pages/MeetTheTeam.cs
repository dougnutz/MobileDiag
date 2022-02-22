using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MobileDiag.Pages;

public class MeetTheTeam : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public MeetTheTeam(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
