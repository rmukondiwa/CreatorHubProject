using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pay2Craft.Pages;

public class CreatePostModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public CreatePostModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}