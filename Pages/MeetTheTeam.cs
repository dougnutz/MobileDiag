using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MobileDiag.Pages;

public class MeetTheTeam : PageModel
{
    private readonly ILogger<baseModel> _logger;

    public MeetTheTeam(ILogger<baseModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
