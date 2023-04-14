using Kolumbus;
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
        playerState.PossibleTransportations = KolumbusService.GetPossibleTransportations(playerState.CurrentPosition);

        return playerState;
    }

    /**
     * card = short version of card. For example "5H" for the five of hearts
     */
    public static PlayerState MakeMove(PlayerState playerState, string lineId, string cardValue)
    {
        // Get correct stop
        Card card = playerState.Hand.First(c => c.value == cardValue);
        StopPlace nextStop = KolumbusService.MoveAlongLine(playerState.CurrentPosition, lineId, card.getMoves());

        // TODO: Update score - check finished goal route

        var timeUsed = KolumbusService.TravelTime(playerState.CurrentPosition, nextStop);
        playerState.TimeUsed += timeUsed;
        // TODO: Check if more time left
        playerState.TimeLeft -= timeUsed;
        playerState.CurrentPosition = nextStop;
        playerState.PossibleTransportations = KolumbusService.GetPossibleTransportations(playerState.CurrentPosition);

        return playerState;
    }
}