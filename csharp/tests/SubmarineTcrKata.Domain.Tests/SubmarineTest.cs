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
    public void SubmarineShouldBeInHorizontalPosition()
    {
        _submarine.Position.Should().Be(0);
    }
}