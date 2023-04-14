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
app.MapGet("/get-my-boi", () => playerState);
app.MapPost(
    "/get-on-vehicle",
    (GetOnVehicleDto dto) => GameService.GetOnVehicle(playerState, dto.VehicleId)
);
app.MapPost("/playCard", () => "");

app.Run();