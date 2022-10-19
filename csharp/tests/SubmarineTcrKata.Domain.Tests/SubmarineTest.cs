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

    [Fact]
    public void ShouldGoDown()
    {
        _submarine.ExecuteCommand("down 1");

        _submarine.Aim.Should().Be(1);
    }
    
    [Fact]
    public void ShouldGoDownTwo()
    {
        _submarine.ExecuteCommand("down 2");

        _submarine.Aim.Should().Be(2);
    }
}