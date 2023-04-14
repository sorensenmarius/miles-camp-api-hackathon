using Kolumbus2Ride.Dto;
using Kolumbus2Ride.Services;
using KolumbusToRide.Domain;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var playerState = new PlayerState();

// ----- Endpoints -------------------------------------------------------
app.MapPost("/start", (string name) => GameService.StartGame(playerState, name));
app.MapGet("/get-my-boi", () => playerState);
app.MapPost("/make-move", (MakeMoveDto dto) => GameService.MakeMove(playerState, dto.TripId, dto.CardValue));

app.Run();