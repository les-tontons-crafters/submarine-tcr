using FluentAssertions;
using Xunit;

namespace SubmarineTcrKata.Domain.Tests;

public class SubmarineTest
{
    private readonly Submarine _submarine;

    public SubmarineTest() => _submarine = new Submarine();

    [Fact]
    public void SomeFakeTest() => _submarine.Should().NotBeNull();

    [Fact]
    public void ShouldHaveInitialPosition()
    {
        _submarine.Position.Should().Be(0);
        _submarine.Aim.Should().Be(0);
        _submarine.Depth.Should().Be(0);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void ShouldGoDown(int value)
    {
        _submarine.ExecuteCommand("down " + value);

        _submarine.Aim.Should().Be(value);
    }
    
    [Fact]
    public void ShouldGoUpTwo()
    {
        _submarine.ExecuteCommand("up 2");

        _submarine.Aim.Should().Be(-2);
    }

    [Theory]
    [InlineData(1)]
    public void ShouldGoUp(int value)
    {
        _submarine.ExecuteCommand("up " + value);

        _submarine.Aim.Should().Be(value * -1);
    }
}