using CapitalPlacement.TalentManagement.Application.Exceptions;
using CapitalPlacement.TalentManagement.Application.Settings;
using CapitalPlacement.TalentManagement.Infrastructure.Data;
using CapitalPlacement.TalentManagement.Infrastructure.Extensions;
using CapitalPlacement.TalentManagement.Application.Extensions;

namespace CapitalPlacement.TalentManagement.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var cosmosDbSettingsSection = builder.Configuration.GetSection(CosmosDbSettings.Name);
            builder.Services.Configure<CosmosDbSettings>(cosmosDbSettingsSection);
            var cosmosDbSettings = cosmosDbSettingsSection.Get<CosmosDbSettings>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddApplicationServices();
            builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
            builder.Services.AddProblemDetails();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

           builder.Services.AddInfrastructureServices<ApplicationDbContext>(cosmosDbSettings?.AccountEndPoint, cosmosDbSettings?.AccountKey, cosmosDbSettings?.DatabaseName);

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                using var scope = app.Services.CreateScope();
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();
                context.Database.EnsureCreated();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
