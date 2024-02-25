using KeyedServicesExample;
using KeyedServicesExample.Interfaces;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddKeyedScoped<INotifier, SMSNotifier>("SMS");
    builder.Services.AddKeyedScoped<INotifier,EmailNotifier>("Email");

}
var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}