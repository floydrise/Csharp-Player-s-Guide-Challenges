/*
Objectives:
• Define enumerations for card colors and card ranks.
• Define a Card class to represent a card with a color and a rank, as described above.
• Add properties or methods that tell you if a card is a number or symbol card (the equivalent of a face card).
• Create a main method that will create a card instance for the whole deck (every color with every rank)
  and display each (for example, “The Red Ampersand” and “The Blue Seven”).
• Answer this question: Why do you think we used a color enumeration here but made a color class in the previous challenge?
*/
Colour[] colours =
[
    Colour.Blue,
    Colour.Green,
    Colour.Red,
    Colour.Yellow
];
Rank[] ranks =
[
    Rank.One,
    Rank.Two,
    Rank.Three,
    Rank.Four,
    Rank.Five,
    Rank.Six,
    Rank.Seven,
    Rank.Eight,
    Rank.Nine,
    Rank.Ten,
    Rank.Ampersand,
    Rank.Circumflex,
    Rank.Dollar,
    Rank.Percent
];

foreach (Colour colour in colours)
{
    foreach (Rank rank in ranks)
    {
        Card card = new(colour, rank);
        System.Console.WriteLine($"The {card.Colour} {card.Rank}");
    }
}

public class Card (Colour colour, Rank rank)
{
    public Colour Colour {get;} = colour;
    public Rank Rank {get;} = rank;

    public bool IsSymbol => Rank == Rank.Dollar || Rank == Rank.Percent || Rank == Rank.Circumflex || Rank == Rank.Ampersand;
    public bool IsNumber => !IsSymbol;

}
public enum Colour {Red, Green, Blue, Yellow}
public enum Rank {One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Circumflex, Ampersand}