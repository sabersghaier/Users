using dropouts.Models;
using Microsoft.EntityFrameworkCore;

namespace dropouts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<dbtestContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("dbtestContext")));
            // Add services to the container.

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:3032")
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors();

            app.MapControllers();

            app.Run();
           


        }

    }
}
