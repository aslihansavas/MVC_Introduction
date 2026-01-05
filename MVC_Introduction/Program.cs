//Model View Controller
//Controlller: istekleri ilk kar??layan mekanizma
//View: sayfalar?n ait oldu?u alan (html)
//Model:model classlar?n bar?nd?r?ld??? alan

using Microsoft.EntityFrameworkCore;
using MVC_Introduction.Contexts;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //services

        builder.Services.AddMvc();
        builder.Services.AddDbContext<MyContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());
        var app = builder.Build();

        // minimal request
        //app.MapGet("/contact", () => "?leti?im");
        //app.MapGet("/about", () => "Hakk?m?zda");

        //Routing
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            //proje aya?a kald?r?ld???nda varsay?lan olarak home adnda bir controller 
            //ve bu controller içerisinde index ad?nda bir metota istek yönlendirecek.

            endpoints.MapDefaultControllerRoute();

        });

        //pipeline
        app.Run();
    }
}