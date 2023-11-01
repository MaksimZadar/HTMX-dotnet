namespace RazorViews.Views.Shared.NavBar
{
    public class NavBarModel
    {
        public List<NavBarRouteModel> Routes { get; set; } = new();
    }

    public class NavBarRouteModel
    {
        public string Path { get; set; } = "/";
        public string Label { get; set; } = "DefaultRouteLabel";
    }
}
