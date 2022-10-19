namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public Submarine()
    {
    }

    public void ExecuteCommand(string command) => throw new NotImplementedException();
    public int Aim => 0;
    public int Position => 0;
    public int Depth => 0;
}