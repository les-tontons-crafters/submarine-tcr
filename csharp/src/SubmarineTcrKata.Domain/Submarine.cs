namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public Submarine()
    {
    }

    public void ExecuteCommand(string command)
    {
        Aim = 1;
    }

    public int Aim { get; set; } 
    public int Position => 0;
    public int Depth => 0;
}