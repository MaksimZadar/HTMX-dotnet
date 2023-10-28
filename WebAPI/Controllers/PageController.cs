using System.Net.Mime;

using Microsoft.AspNetCore.Mvc;

namespace WebAPI;

[ApiController]
[Route("/")]
public class PageController : ControllerBase
{

    [HttpGet("/", Name = "Home")]
    public IResult Home()
    {

        return Results.Content("<h1>Hi</h1>", MediaTypeNames.Text.Html);
    }

}
