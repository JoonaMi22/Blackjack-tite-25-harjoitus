using System.Collections.Generic;
using System.Linq;

public class Player
{
	public List<Card> Hand { get; } = new List<Card>();


	public int Score
	{
		get
		{
			return Hand.Sum(card => card.Value);
		}
	}
	public void TakeCard(Card card)

	{
		Hand.Add(card);
	}

	public virtual void PlayTurn(Deck deck)
	{
		Console.WriteLine("Pelaajan vuoro");

	}
}