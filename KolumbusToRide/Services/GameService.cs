using Kolumbus;
using Kolumbus2Ride.Domain;
using KolumbusToRide.Domain;
using Card = DeckOfCards.Card;

namespace Kolumbus2Ride.Services;

public static class GameService
{
    public static PlayerState StartGame(PlayerState playerState, string name)
    {
        playerState = new PlayerState
        {
            Name = name,
            CurrentPosition = KolumbusService.GetRandomStopPlace(),
            GoalPosition = KolumbusService.GetRandomStopPlace(),
            TimeLeft = TimeSpan.FromHours(2)
        };

        return playerState;
    }
    
    /**
     * card = short version of card. For example "5H" for the five of hearts
     */
    public static PlayerState MakeMove(PlayerState playerState, string lineId, string cardValue)
    {
        // Get correct stop
        Card card = playerState.Hand.First(c => c.value == "cardValue");
        StopPlace nextStop = KolumbusService.MoveAlongLine(lineId, card.getMoves());
        
        // Add time to next stop to playerState.timePlayed

        // TODO: Update score - check finished goal route
        // TODO: Check if more time left


        playerState.CurrentPosition = nextStop;

        return playerState;
    }
}