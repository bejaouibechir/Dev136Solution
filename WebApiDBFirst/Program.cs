
using Microsoft.EntityFrameworkCore;
using WebApiDBFirst.Model;

namespace WebApiDBFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //Enregistrement de FirstDbContext en tant que service 
            builder.Services.AddDbContext<FirstDbContext>(options =>
            options.UseSqlServer("Data Source=PC2023\\PC2023;Initial Catalog=FirstDB;TrustServerCertificate=true;" +
            "Integrated Security=True"));
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}