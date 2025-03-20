using API_Nomina.Services;
using API_Nomina.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsuarioService, UsuariosServices>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    return new UsuariosServices(configuration);
});

builder.Services.AddScoped<IEmpleadosService, EmpleadosService>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    return new EmpleadosService(configuration);
});

builder.Services.AddScoped<ITurnosService, TurnosService>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    return new TurnosService(configuration);
});

builder.Services.AddScoped<IGestionService, GestionService>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    return new GestionService(configuration);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

app.Run();
