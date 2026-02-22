namespace Test;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        var version = "Version 1.3.0";

        app.MapGet("/", () => $"Unit Status: ONLINE | {version} | Time: {DateTime.Now} | IM GAY!! yayyy");
        app.Run();
    }
}