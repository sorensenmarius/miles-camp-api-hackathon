using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
        public string code {get; set;}
        public string image {get; set;}
        public string value {get; set;}
        public string suit {get; set;}
     }
}
public record Card(
    string code,
    string image,
    Images images,
    string value,
    // Enum maybe?
    string suit
)
{
    public int getMoves()
    {
        return value switch
        {
            "JACK" => 11,
            "QUEEN" => 12,
            "KING" => 13,
            "ACE" => 14,
            _ => int.Parse(value)
        };
    }
};

public record Images(
    string svg,
    string png
);

