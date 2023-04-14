using System.Net.Http;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolumbus;
using DeckOfCards;

namespace Kolumbus2Ride.Domain
{

    public class Hand : IHand
    {
        Deck Deck = null;
        private DeckOfCards.NewDeckResponse currentDeck = new DeckOfCards.NewDeckResponse();

        public void DrawCard()
        {
            if (Deck == null)
            {
                DrawNewDeck();
                Shuffle();
            }
            Deck = Draw5Card();


        }

        private Deck Draw5Card()
        {
            HttpClient client = new HttpClient();
            string url = "https://deckofcardsapi.com/api/deck/"+currentDeck.deck_id+"/draw/?count=2";
            var response = client.GetFromJsonAsync<DeckOfCards.Deck>(url).Result;
            return response;
        }

        private async void Shuffle() {
            HttpClient client = new HttpClient();
            string url = "https://deckofcardsapi.com/api/deck/" + currentDeck.deck_id + "/shuffle/";
            var response = client.GetFromJsonAsync<DeckOfCards.NewDeckResponse>(url).Result;
            Console.WriteLine("Cards shuffled" + response.success);
        }


        private async void DrawNewDeck()
        {
            HttpClient client = new HttpClient();
            var Deck = client.GetFromJsonAsync<DeckOfCards.NewDeckResponse>("https://deckofcardsapi.com/api/deck/new/").Result;
            if (Deck.success)
            {
                currentDeck = Deck;
                Console.WriteLine("Drawing new deck " + Deck.success);
            }
            else
            {
                throw new Exception("Unable to get new deck from api");
            }
        }

        public void playCard(Card playedCard)
        {
            throw new NotImplementedException();
        }
    }

    public interface IHand
    {
        public void DrawCard();
        public void playCard(Card playedCard);
    }
}