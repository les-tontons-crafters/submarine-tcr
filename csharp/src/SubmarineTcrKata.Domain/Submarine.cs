namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public Submarine()
    {
    }

    public void ExecuteCommand(string command)
    {
        if (command == "down 1")
        {
            Aim = 1;
        }
        else
        {
            Aim = 2;
        }
    }

    public int Aim { get; private set; } 
    public int Position => 0;
    public int Depth => 0;
}