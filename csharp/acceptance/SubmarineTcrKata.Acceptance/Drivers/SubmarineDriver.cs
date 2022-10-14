using SubmarineTcrKata.Domain;

namespace SubmarineTcrKata.Acceptance.Drivers;

public class SubmarineDriver
{
    private readonly Submarine submarine;

    public SubmarineDriver(Submarine submarine) => this.submarine = submarine;

    public int GetSubmarineDepth() => this.submarine.Depth;
    
    public int GetSubmarineAim() => this.submarine.Aim;
    
    public int GetSubmarinePosition() => this.submarine.Position;
    
    public int GetFinalValue() => this.submarine.Position * this.submarine.Depth;
    
    public void SendCommand(string command) => this.submarine.ExecuteCommand(command);
}