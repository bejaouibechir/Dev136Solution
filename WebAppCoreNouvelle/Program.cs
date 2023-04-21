using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using WebAppCoreNouvelle.Middlewares;
using WebAppCoreNouvelle.Services;

var builder = WebApplication.CreateBuilder(args);

ServiceDescriptor descriptor = new ServiceDescriptor(typeof(ILoggerService),
    typeof(LoggerService), ServiceLifetime.Transient);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Add(descriptor);
builder.Services.AddScoped<IEmployeeService,EmployeeService>();

builder.Services.AddSingleton<ISingletonService,SingletonService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddTransient<ITransientService, TransientService>();


//Utiliser builder.Configuration pour récupérer les paramètres nécessaires pour l'application
var configuraton = builder.Configuration;
string connectionstring; 


var app = builder.Build();

// Contexte de développement
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if(app.Environment.IsDevelopment()) //Le contexte de développement
{
    connectionstring = configuraton.GetConnectionString("devdb");

}
else if(app.Environment.IsStaging())// Le contexte de test
{
    connectionstring = configuraton.GetConnectionString("testdb");
}
else if(app.Environment.IsProduction()) //Le contexte de production
{
    connectionstring = configuraton.GetConnectionString("proddb");
}

//Utilser à présent la chaine correspendante ici
;

//Middleware 1  app.UseMiddleware1();
//app.Use(async (context, next) =>
//{
//    ;//traitement de la requete niveau middleware 1
//    Debug.WriteLine("traitement de la requete niveau middleware 1");
//    await next ();
//    ;//traitement de la reponse niveau middleware 1
//    Debug.WriteLine("traitement de la reponse niveau middleware 1");
//});

//app.UseMiddleware1();




app.UseMonMiddleWare();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

