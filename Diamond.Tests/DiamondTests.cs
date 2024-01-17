namespace Diamond.Tests;

public class DiamondTests
{
    [Fact]
    public void Test_Invalid_Input()
    {
        Assert.Throws<ArgumentException>(() => new Diamond('1'));
    }

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
        var diamond = new Diamond('C', true);
        var expected = @"
__A__
_B_B_
C___C
_B_B_
__A__
"[1..];
        var actual = diamond.ToString();


        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_G_Diamond()
    {
        var diamond = new Diamond('G', true);
        var expected = @"
______A______
_____B_B_____
____C___C____
___D_____D___
__E_______E__
_F_________F_
G___________G
_F_________F_
__E_______E__
___D_____D___
____C___C____
_____B_B_____
______A______
"[1..];
        var actual = diamond.ToString();


        Assert.Equal(expected, actual);
    }


    [Fact]
    public void Test_K_Diamond_no_whitespace()
    {
        var diamond = new Diamond('K', false);
        var expected =
@"
          A          
         B B         
        C   C        
       D     D       
      E       E      
     F         F     
    G           G    
   H             H   
  I               I  
 J                 J 
K                   K
 J                 J 
  I               I  
   H             H   
    G           G    
     F         F     
      E       E      
       D     D       
        C   C        
         B B         
          A          
"[1..];
        var actual = diamond.ToString();


        Assert.Equal(expected, actual);
    }
}
