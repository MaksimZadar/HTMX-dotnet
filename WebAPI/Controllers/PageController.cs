using System.Net.Mime;

using Htmx;

using Microsoft.AspNetCore.Mvc;

using RazorViews;

namespace WebAPI;

[ApiController]
[Route("/")]
public class PageController : ControllerBase
{
    private readonly IRazorViewToStringRenderer _razorViewToStringRenderer;

    public PageController(IRazorViewToStringRenderer razorViewToStringRenderer)
    {
        _razorViewToStringRenderer = razorViewToStringRenderer;
    }

    [HttpGet("/", Name = "Home")]
    public async Task<IResult> HomePage()
    {
        var (view, data) = HtmxPageSelection.GetViewAndData("~/Pages/Home.cshtml", DateTime.Now, Request.IsHtmx() && !Request.IsHtmxHistoryRestoreRequest());

        return Results.Content(
            await _razorViewToStringRenderer.RenderViewToStringAsync(view, data),
            MediaTypeNames.Text.Html);
    }
}