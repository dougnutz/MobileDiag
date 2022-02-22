using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MobileDiag.Pages;

public class HealthModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public HealthModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

