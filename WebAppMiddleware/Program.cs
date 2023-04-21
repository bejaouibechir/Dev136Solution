

using Microsoft.AspNetCore.Http;

namespace WebAppMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            ;

            
            app.Map("/middleware1",ap=>ap.Response.WriteAsync("<h1>Middleware 1</h1>"));
            
            
            string path = "middleware1";

            app.MapWhen(context=> (path=="middlware1"), ap => ap.Run(context=>context.
            Response.WriteAsync("<h1>Middleware 1 </h1 >")));


            app.Run();
            
            ////Middleware 1
            //app.Use(async (context,next) =>
            //{
            //   await context.Response.WriteAsync("Le middleware 1 traitement de requête");
            //   await next();
            //   await context.Response.WriteAsync("Le middleware 1 traitement de reponse");
            //});

            ////Middleware 2
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Le middleware 2 traitement de requête");
            //    await next();
            //    await context.Response.WriteAsync("Le middleware 2 traitement de reponse");
            //});

            ////Middleware 3
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Le middleware 3 traitement de requête");
            //    await next();
            //    await context.Response.WriteAsync("Le middleware 3 traitement de reponse");
            //});

            //app.Run();


            //Middleware 4
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Le middleware 4 traitement de requête");
            //    await next();
            //    await context.Response.WriteAsync("Le middleware 4 traitement de reponse");
            //});



            //string path = "middleware2";

            //app.Map("/middleware1",
            //    ap => ap.Run(context => context
            //.Response.WriteAsync("<h1>Middleware 1</h1>")));
            //app.Run();




            //  app.MapWhen(context => (path == "middleware1"),
            //      ap => ap.Run(context => context
            //  .Response.WriteAsync("<h1>Middleware 1</h1>")));



            //  app.MapWhen(context => (path == "middleware2")
            //      , ap => ap.Run(context => context
            //.Response.WriteAsync("<h1>Ce ci est le middleware 2</h1>")));



        }
    }
}


/*
 app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
 
 */