using FluentAssertions;
using SubmarineTcrKata.Acceptance.Drivers;

namespace SubmarineTcrKata.Acceptance.Steps;

[Binding]
public sealed class SubmarineSteps
{
    private readonly SubmarineDriver _driver;

    public SubmarineSteps(SubmarineDriver driver) => _driver = driver;

    [Then(@"submarine depth should be (.*)")]
    public void VerifySubmarineDepth(int depth) => _driver.GetSubmarineDepth().Should().Be(depth);

    [Then(@"submarine position should be (.*)")]
    public void VerifySubmarinePosition(int position) => _driver.GetSubmarinePosition().Should().Be(position);

    [Then(@"submarine aim should be (.*)")]
    public void VerifySubmarineAim(int aim) => _driver.GetSubmarineAim().Should().Be(aim);

    [Then(@"submarine final value should be (.*)")]
    public void VerifySubmarineFinalValue(int finalValue) => _driver.GetFinalValue().Should().Be(finalValue);

    [Given(@"submarine receives command (.*)")]
    [When(@"submarine receives command (.*)")]
    public void SendCommand(string command) => _driver.SendCommand(command);

    [When(@"submarine receives all commands from file (.*)")]
    public void SendCommands(string filename)
    {
        var lines = File.ReadLines(string.Concat(Directory.GetCurrentDirectory(), filename));
        lines.ToList().ForEach(_driver.SendCommand);
    }

    [Then(@"submarine final value should match value from file (.*)")]
    public void VerifySubmarineFinalValueFromFile(string filename)
    {
        var finalValue = File.ReadLines(string.Concat(Directory.GetCurrentDirectory(), filename)).First();
        _driver.GetFinalValue().Should().Be(int.Parse(finalValue));
    }
}