using FluentAssertions;
using Xunit;

namespace SubmarineTcrKata.Domain.Tests;

public class SubmarineTest
{
    private readonly Submarine _submarine;

    public SubmarineTest()
        => _submarine = new Submarine();

    [Fact]
    public void SomeFakeTest()
        => _submarine.Should().NotBeNull();

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
    [InlineData(3)]
    public void ShouldGoDown(int value)
    {
        _submarine.ExecuteCommand("down " + value);

        _submarine.Aim.Should().Be(value);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void ShouldGoUp(int value)
    {
        _submarine.ExecuteCommand("up " + value);

        _submarine.Aim.Should().Be(-value);
    }

    [Fact]
    public void ShouldGoForward()
    {
        _submarine.ExecuteCommand("forward 5");

        _submarine.Position.Should().Be(5);
        _submarine.Depth.Should().Be(0);
    }

    [Fact]
    public void ShouldGoForward8()
    {
        // Arrange
        _submarine.ExecuteCommand("down 5");
        
        // Act
        _submarine.ExecuteCommand("forward 8");

        // Assert
        _submarine.Position.Should().Be(8);
        _submarine.Depth.Should().Be(5 * 8);
    }
}