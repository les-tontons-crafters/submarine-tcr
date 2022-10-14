using FluentAssertions;
using SubmarineTcrKata.Acceptance.Drivers;

namespace SubmarineTcrKata.Acceptance.Steps;

[Binding]
public sealed class SubmarineSteps
{
    private readonly SubmarineDriver driver;

    public SubmarineSteps(SubmarineDriver driver) => this.driver = driver;

    [Then(@"submarine depth should be (.*)")]
    public void VerifySubmarineDepth(int depth) => this.driver.GetSubmarineDepth().Should().Be(depth);

    [Then(@"submarine position should be (.*)")]
    public void VerifySubmarinePosition(int position) => this.driver.GetSubmarinePosition().Should().Be(position);

    [Then(@"submarine aim should be (.*)")]
    public void VerifySubmarineAim(int aim) => this.driver.GetSubmarineAim().Should().Be(aim);

    [Then(@"submarine final value should be (.*)")]
    public void VerifySubmarineFinalValue(int finalValue) => this.driver.GetFinalValue().Should().Be(finalValue);

    [When(@"submarine receives command (.*)")]
    public void SendCommand(string command) => this.driver.SendCommand(command);
}