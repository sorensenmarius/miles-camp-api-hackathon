using Kolumbus;
using KolumbusToRide.Domain;

namespace Kolumbus2Ride.Services;

public static class GameService
{
    public static PlayerState GetOnVehicle(PlayerState playerState, string vehicleId)
    {
        // 1. Get next stop
        // 2. Add time to next stop to playerState.timePlayed
        // 3. Set position to next stop
        // 4. Use relevant cards
        // 5. Update score - check finished goal route
        // 6. Check if more time left
        playerState.Name = "BRYNJ";

        return playerState;
    }
}