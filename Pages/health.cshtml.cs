using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MobileDiag.Pages;

public class HealthModel : PageModel
{
    private readonly ILogger<HealthModel> _logger;

    public HealthModel(ILogger<HealthModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

