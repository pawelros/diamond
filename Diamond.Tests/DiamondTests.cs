namespace Diamond.Tests;

public class DiamondTests
{
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
