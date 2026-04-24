using System;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
    private List<Card> cards = new List<Card>(); //oliokokoelma
    private Random random = new Random();

    public Deck()
    {
        CreateDeck();
        Suffle();
    }

    private void CreateDeck()
    {
        string[] suits = { "Hertta", "Pata", "Ruutu", "Risti" };
        string[] ranks =
        {
            "A", "2", "3", "4", "5","6", "7", "8", "9", "10", "J", "Q", "K"
        };

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Suffle()
    {
        cards = cards.OrderBy(x => random.Next()).ToList();
    }
    public Card DrawCard()
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}
