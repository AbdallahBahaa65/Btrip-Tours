namespace B_Trip_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();



            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Home}/{action=Index}"
                );


            app.Run();
        }
    }
}
