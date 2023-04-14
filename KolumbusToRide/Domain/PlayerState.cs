using DeckOfCards;
using Kolumbus;

namespace KolumbusToRide.Domain;

public class PlayerState
{
    private string Name { get; set; }
    private int Score { get; set; }
    private TimeSpan TimeUsed { get; set; }
    private TimeSpan TimeLeft { get; set; }
    private List<Card> Hand { get; set; }
    private StopPlace CurrentPosition { get; set; }
    private List<Vehicle> PossibleTransportations { get; set; }
}