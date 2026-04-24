using System;

public class Blackjack
{
    //luokasta oliot
    private Deck deck = new Deck();
    private Player player = new Player();
    private Player dealer = new Dealer(); //polymorphismi
    private SaveManager saveManager = new SaveManager();


    public void Start()
	// alustus
	// pelaajan vuoro
	// jakajan vuoro  
	// voittajan tarkistus
	{
		Console.WriteLine("BLACKJACK");
		saveManager.Load();
		Console.WriteLine("Viimeisin käsi: " + saveManager.LastScore); //property kenttä


		player.TakeCard(deck.DrawCard());
        player.TakeCard(deck.DrawCard());

        dealer.TakeCard(deck.DrawCard());
        dealer.TakeCard(deck.DrawCard());

        PlayerTurn();


        if (player.Score <= 21)
        {
            DealerTurn();
            CheckWinner();
        }
    }

    private void PlayerTurn()
    {
        while (true)
        {
            Console.WriteLine("Piste määräsi: " + player.Score);
            Console.WriteLine("Nosta vai jätä? (n/j)");

            string? input = Console.ReadLine()?.ToLower();

            if (input == "n")
            {
                player.TakeCard(deck.DrawCard());

                if (player.Score > 21)
                {
                    Console.WriteLine("Yli. Jakaja voittaa.");
                    return;
                }
            }
            else if (input == "j")
            {
                break;
            }
        }
    }

    private void DealerTurn()
    {
        Console.WriteLine("\nJakajan vuoro.");

		dealer.PlayTurn(deck);

		Console.WriteLine($"Jakajan pistemäärä: {dealer.Score}");
    }

    private void CheckWinner()
    {
        Console.WriteLine($"\nPisteesi: {player.Score}");
        Console.WriteLine($"Jakajan pisteet: {dealer.Score}");

        if (dealer.Score > 21 || player.Score > dealer.Score)
            Console.WriteLine("Voitit");
        else if (player.Score < dealer.Score)
            Console.WriteLine("Jakaja voittaa");
        else
            Console.WriteLine("Tasapeli");
		saveManager.LastScore = player.Score;
		saveManager.Save();

	}
}
