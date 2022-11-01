public class Player
{
    private string name;
    private List<Card> hand;
    public Player(string name)
    {
        this.name = name;
        hand = new List<Card>();
    }

    public string Name{
        get { return name; }
    }

    public Card Draw(Deck d)
    {
        Card theCard = d.Deal();
        hand.Add(theCard);
        return theCard;
    }

    public Card Discard(int i)
    {
        Card theCard;
        if (i < hand.Count)
        {
            theCard = hand[i];
            hand.RemoveAt(i);
            return theCard;
        }
        else { return null!; }
    }

}