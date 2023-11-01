
namespace RazorViews;

public static class HtmxPageSelection
{
    public static (string view, object data) GetViewAndData(string childViewPath, object viewData, bool isHtmxRequest)
    {
        if (isHtmxRequest) return (childViewPath, viewData);

        var fullLayoutPath = "~/Pages/FullPage.cshtml";

        return (fullLayoutPath, (childViewPath, viewData));
    }
}