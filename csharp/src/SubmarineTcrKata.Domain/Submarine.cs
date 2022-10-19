namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public Submarine()
    {
    }

    public void ExecuteCommand(string command)
    {
        Aim = command switch
        {
            "down 1" => 1,
            "down 2" => 2,
            "up 1" => -1,
            "up 2" => -2,
            _ => 0
        };
    }

    public int Aim { get; private set; } 
    public int Position => 0;
    public int Depth => 0;
}