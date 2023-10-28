using System.CodeDom.Compiler;

using Microsoft.AspNetCore.Mvc;

namespace HtmxDotnet;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{

    [HttpGet("hello")]
    public IResult HelloWorld()
    {
        return Results.Extensions.RazorSlice("/Views/FullView.cshtml", "Hello");
    }

}
