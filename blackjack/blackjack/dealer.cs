public class Dealer : Player //perii metodit player luokasta
{
	public override void PlayTurn(Deck deck) //ylikirjoittaa metodin
	{
		Console.WriteLine("Jakajan vuoro");

		while (Score < 17)
		{
			TakeCard(deck.DrawCard());
		}
	}
}