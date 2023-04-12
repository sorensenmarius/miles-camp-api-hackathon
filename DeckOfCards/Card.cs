namespace DeckOfCards;

public record Card(
    string code,
    string image,
    Images images,
    string value,
    // Enum maybe?
    string suit
);

public record Images(
    string svg,
    string png
);

