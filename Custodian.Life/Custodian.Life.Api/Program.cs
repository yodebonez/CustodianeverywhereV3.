using Custodian.Life.Api.Services.Services;
using Custodian.Life.Helpers.Helpers;

namespace Custodian.Life.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.Configure<ConnectionStringOptions>(builder.Configuration.GetSection(ConnectionStringOptions.Position));



            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(typeof(Services.PolicyServices.GetPolicyHandler).Assembly);
            });

            // builder.Services.AddScoped<IPolicyServices>(services => new PolicyServices("myconnectionstring"));

            builder.Services.AddScoped<IPolicyServices,PolicyServices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}