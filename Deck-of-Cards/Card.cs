public class Card
{
    public string Name;
    public string Suit;
    public int Val;

    public Card(string suit, int val)
    {
        switch (val)
        {
            case 1:
                Name = "Ace";
                break;
            case 11:
                Name = "Jack";
                break;
            case 12:
                Name = "Queen";
                break;
            case 13:
                Name = "King";
                break;
            default:
                Name = val.ToString();
                break;
        }
        Suit = suit;
        Val = val;
    }

    public override string ToString()
    {
        return $@"
        Name: {Name}
        Suit: {Suit}
        Vak: {Val}";
    }
}