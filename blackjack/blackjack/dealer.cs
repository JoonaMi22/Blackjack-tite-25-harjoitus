public class Dealer : Player
{
	public override void PlayTurn(Deck deck)
	{
		Console.WriteLine("Jakajan vuoro");

		while (Score < 17)
		{
			TakeCard(deck.DrawCard());
		}
	}
}