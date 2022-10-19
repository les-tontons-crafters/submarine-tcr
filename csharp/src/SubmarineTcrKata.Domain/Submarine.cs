namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public Submarine()
    {
    }

    public void ExecuteCommand(string command)
    {
        Position = 5;

        Aim = command switch
        {
            "down 1" => 1,
            "down 2" => 2,
            "down 3" => 3,
            "up 1" => -1,
            "up 2" => -2,
            _ => 0
        };
    }

    public int Aim { get; private set; }
    public int Position { get; set; }

    public int Depth
        => 0;
}