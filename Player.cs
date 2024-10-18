internal class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Score { get; set; } = 0;

    public int Sum = 0;
    public int Bonus = 0;
    public int Number;
    public int RoundScore;

    public bool Ones = false;
    public int OnesScore;
    public bool Twos = false;
    public int TwosScore;
    public bool Threes = false;
    public int ThreesScore;
    public bool Fours = false;
    public int FoursScore;
    public bool Fives = false;
    public int FivesScore;
    public bool Sixes = false;
    public int SixesScore;
    public bool OnePair = false;
    public int OnePairScore;
    public bool TwoPaires = false;
    public int TwoPairesScore;
    public bool ThreeOfTheSame = false;
    public int ThreeOfTheSameScore;
    public bool FourOfTheSame = false;
    public int FourOfTheSameScore;
    public bool House = false;
    public int HouseScore;
    public bool SmallStraight = false;
    public int SmallStraightScore;
    public bool BigStraight = false;
    public int BigStraightScore;
    public bool Chance = false;
    public int ChanceScore;
    public bool Yatzy = false;
    public int YatzyScore = 0;

    public Player(int id, string name)
    {
        Id = id;
        Name = name;
    }
}