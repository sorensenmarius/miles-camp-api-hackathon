namespace DeckOfCards;

public record Deck(
    bool success,
    string deck_id,
    bool shuffled,
    int remaining,
    // Maybe this should be extracted to its own class called "Hand" or a specific Dto.
    List<Card> cards
);