using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pay2Craft.Pages;

public class FeedModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public FeedModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
