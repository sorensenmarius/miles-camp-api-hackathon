var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ----- Endpoints -------------------------------------------------------
app.MapGet("/", () => "Hello World!");
app.MapPost("/playCard", () => "");
app.Run();