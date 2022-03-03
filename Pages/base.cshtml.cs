using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MobileDiag.Pages;

public partial class baseModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;


    public baseModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
