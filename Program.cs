using Microsoft.EntityFrameworkCore;
using Npgsql;
using DBase.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Entity Framework
        string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connection));
        // ---

        // CORS
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins",
                builder => builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader());
        });
        // ---

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            // CORS
            app.UseCors("AllowAllOrigins");

        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}