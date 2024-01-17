﻿namespace Diamond.Tests;

public class RowTests
{
    [Fact]
    public void Test_Row_C_d_5()
    {
        var row = new Row('C', 5, true);
        var expected = "C___C";

        Assert.Equal(expected, row.ToString());
    }

    [Fact]
    public void Test_Row_C_d_7()
    {
        var row = new Row('C', 7, true);
        var expected = "_C___C_";

        Assert.Equal(expected, row.ToString());
    }

    [Fact]
    public void Test_Row_B_d_5()
    {
        var row = new Row('B', 5, true);
        var expected = "_B_B_";

        Assert.Equal(expected, row.ToString());
    }

    [Fact]
    public void Test_Row_B_d_7()
    {
        var row = new Row('B', 7, true);
        var expected = "__B_B__";

        Assert.Equal(expected, row.ToString());
    }

    [Fact]
    public void Test_Row_A_d_5()
    {
        var row = new Row('A', 5, true);
        var expected = "__A__";

        Assert.Equal(expected, row.ToString());
    }

    [Fact]
    public void Test_Row_A_d_7()
    {
        var row = new Row('A', 7, true);
        var expected = "___A___";

        Assert.Equal(expected, row.ToString());
    }
}
