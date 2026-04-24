public class Card
{
    public string Suit { get; set; } //property
    public string Rank { get; set; }

    public Card(string suit, string rank) //konstruktori
    {
        Suit = suit;
        Rank = rank;
    }

    public int Value
    {
        get
        {
            if (Rank == "A") return 11;
            if (Rank == "K" || Rank == "Q" || Rank == "J") return 10;
            return int.Parse(Rank);
        }
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";

    }

}