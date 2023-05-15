
using Levva.Newbies.Intensivo.Data;
using Levva.Newbies.Intensivo.Data.Interfaces;
using Levva.Newbies.Intensivo.Data.Repositories;
using Levva.Newbies.Intensivo.Logic.Interfaces;
using Levva.Newbies.Intensivo.Logic.MapperProfiles;
using Levva.Newbies.Intensivo.Logic.Services;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Levva.Newbies.Intensivo;

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

        builder.Services.AddDbContext<Context>(options => options.UseSqlite(builder.Configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("Levva.Newbies.Intensivo")));

        builder.Services.AddAutoMapper(typeof(DefaultMapper));

        builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        builder.Services.AddScoped<ITransacaoRepository, TransacaoRepository>();
        builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();

        builder.Services.AddScoped<IUsuarioService, UsuarioService>();
        builder.Services.AddScoped<ITransacaoService, TransacaoService>();
        builder.Services.AddScoped<ICategoriaService, CategoriaService>();

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

        var cultureInfo = new CultureInfo("pt-bt");
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        
        app.Run();
    }
    

}
