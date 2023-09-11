using Custodian.Life.Api.Services.Services;

namespace Custodian.Life.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(typeof(Services.PolicyServices.GetPolicyHandler).Assembly);
            });

            builder.Services.AddScoped<IPolicyServices>(services => new PolicyServices("myconnectionstring"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}