
using EstudiantePrueba.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EstudiantePrueba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var conecctiom = builder.Configuration.GetConnectionString("connection");
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ContextDB>(op=> op.UseSqlServer(conecctiom));
            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddCors(x =>
            {
                x.AddDefaultPolicy(y =>
                {
                    y.WithOrigins("http://127.0.0.1:5173").AllowAnyMethod().AllowAnyHeader();
                    //.WithExposedHeaders(new string[] { "cantidadTotalRegistros" }); //Sirve para devolver cabezaras y es de buena practica ponerlo
                });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
