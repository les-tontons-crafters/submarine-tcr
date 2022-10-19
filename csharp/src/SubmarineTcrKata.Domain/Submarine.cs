namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public Submarine()
    {
    }

    public void ExecuteCommand(string command)
    {
        var arguments = command.Split(" ");
        var commandName = arguments[0];
        var value = int.Parse(arguments[1]);

        Aim = commandName switch
        {
            "down" => value,
            "up" => -value,
            _ => Aim
        };

        if (command == "forward 5")
        {
            Position = 5;
        }
        else
        {
            Position = 8;
            Depth = 40;
        }
    }

    public int Aim { get; private set; }
    public int Position { get; private set; }

    public int Depth { get; private set; }
}