using GooseHtml.Components;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddComponents();
        var app = builder.Build();
        app.UseComponents();


        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}
