using DeckOfCards;
using Kolumbus;
using Kolumbus2Ride.Domain;

namespace KolumbusToRide.Domain;

public class PlayerState
{
    public string Name { get; set; }
    public int Score { get; set; }
    public TimeSpan TimeUsed { get; set; }
    public TimeSpan TimeLeft { get; set; }
    public IHand Hand { get; set; }
    public StopPlace CurrentPosition { get; set; }
    public StopPlace GoalPosition { get; set; }
    public List<Vehicle> PossibleTransportations { get; set; }
}