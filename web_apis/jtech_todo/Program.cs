using TodoApi.Data;
using TodoApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(); 

var version = new Version(1, 0, 0);

#region tasks
TaskEndpoints.MapEndpoints(app,version);
#endregion

#region todos
TodoEndpoints.MapEndpoints(app,version);
#endregion

#region todos
PomodoroEndpoints.MapEndpoints(app,version);
#endregion

app.Run();
