using SubmarineTcrKata.Domain;

namespace SubmarineTcrKata.Acceptance.Drivers;

public class SubmarineDriver
{
    private readonly Submarine _submarine;

    public SubmarineDriver(Submarine submarine) => _submarine = submarine;

    public int GetSubmarineDepth() => _submarine.Depth;
    public int GetSubmarineAim() => _submarine.Aim;
    public int GetSubmarinePosition() => _submarine.Position;
    public int GetFinalValue() => _submarine.Position * _submarine.Depth;
    public void SendCommand(string command) => _submarine.ExecuteCommand(command);
}