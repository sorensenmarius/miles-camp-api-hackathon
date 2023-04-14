using System.Net.Http;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolumbus2Ride.Domain
{

    public class Hand : IHand
    {
        List<Card>? ThisHand = null;

        public void DrawCard()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Card>> GetCardsAsync()
        {
            if (ThisHand == null)
            {
                ThisHand = new List<Card>();
                ThisHand = await DrawHand();
            }
            throw new NotImplementedException();
        }

        private async Task<List<Card>> DrawHand()
        {
            HttpClient client = new HttpClient();

            var result = await client.GetAsync("https://deckofcardsapi.com/api/deck/new/");
            Console.WriteLine(result.StatusCode);
            Console.WriteLine(result.ToString());   //GET Method

            throw new NotImplementedException();
        }

        public void playCard(Card playedCard)
        {
            throw new NotImplementedException();
        }
    }

    public interface IHand
    {
        public Task<List<Card>> GetCardsAsync();
        public void DrawCard();
        public void playCard(Card playedCard);
    }
}