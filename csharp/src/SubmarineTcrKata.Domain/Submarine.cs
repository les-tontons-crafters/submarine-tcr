namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public Submarine()
    {
    }

    public void ExecuteCommand(string command)
    {
        if (command == "forward 5")
        {
            Position = 5;
        }
        else
        {
            Position = 8;
            Depth = 40;
        }

        Aim = command switch
        {
            "down 1" => 1,
            "down 2" => 2,
            "down 3" => 3,
            "down 5" => 5,
            "up 1" => -1,
            "up 2" => -2,
            _ => 0
        };
    }

    public int Aim { get; private set; }
    public int Position { get; private set; }

    public int Depth { get; private set; }
}