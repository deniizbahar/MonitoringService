using Günlük; // Günlük namespace'ini import et
using Serilog.Events;

namespace logowebapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Logger'ý yapýlandýr ve tek bir örneði kullan
            var loggerService = new LoggerService("C://Logs/myapp-log.json", LogEventLevel.Information);
            LoggerHelper.ConfigureLogger(loggerService);

            // Default log seviyesini ayarla
            LoggerHelper.SetLogLevel(LogEventLevel.Information);

            // Log when the application starts
            LoggerHelper.Log(LogEventLevel.Information, "Application started");

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Lifetime.ApplicationStopping.Register(() =>
            {
                LoggerHelper.Log(LogEventLevel.Information, "Application stopping");
            });

            app.Run();

            LoggerHelper.Log(LogEventLevel.Information, "Application stopped");
        }
    }
}
