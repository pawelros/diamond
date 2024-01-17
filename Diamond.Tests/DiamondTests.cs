namespace Diamond.Tests;

public class DiamondTests
{
    [Fact]
    public void Test_Depth_A()
    {
        var diamond = new Diamond('A');
        Assert.Equal(1, diamond.Depth);
    }

    [Fact]
    public void Test_Depth_B()
    {
        var diamond = new Diamond('B');
        Assert.Equal(3, diamond.Depth);
    }

    [Fact]
    public void Test_Depth_C()
    {
        var diamond = new Diamond('C');
        Assert.Equal(5, diamond.Depth);
    }

    [Fact]
    public void Test_C_Diamond()
    {
        var diamond = new Diamond('C');
        var expected = @"
__A__
_B_B_
C___C
_B_B_
__A__"[1..];

        Assert.Equal(expected, diamond.ToString());
    }
}
