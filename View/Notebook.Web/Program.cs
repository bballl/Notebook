namespace Notebook.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ��������� � ���������� ������� Razor Pages
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // ��������� ��������� ������������� ��� Razor Pages
            app.MapRazorPages();

            app.Run();
        }
    }
}