using System.Net.Http.Json;
using DeckOfCards;

try
{
    var client = new HttpClient();

    Deck? deck = await client.GetFromJsonAsync<Deck>("https://deckofcardsapi.com/api/deck/new/");

    deck = await client.GetFromJsonAsync<Deck>($"https://deckofcardsapi.com/api/deck/{deck.deck_id}/draw/?count=2");
}
catch (HttpRequestException e)
{
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message :{0} ", e.Message);
}