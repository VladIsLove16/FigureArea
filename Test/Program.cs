using FigureArea;
using Xunit;
float a;

public class CircleSquareTest()
{
    private float negativeException=-1;
    private float notException =0.6f;//s=
    [Fact]
    public void NegativeException()
    {
        Assert.Throws<ArgumentException>(() => FigureArea.FigureArea.CircleSquare(negativeException));
    }
    [Fact]
    public void Normal()
    {
        Assert.InRange(FigureArea.FigureArea.CircleSquare(notException), 1.13, 1.14);
    }
}
public class TriangleSquareTest()
{
    private float[] nullException = [0, 0.5f, 0.6f];
    private float[] negativeException = [-1, 0.5f, 0.6f];
    private float[] notException = [1f, 0.5f, 0.6f];//s=
    [Fact]
    public void NullException()
    {
        Assert.Throws<ArgumentException>(() => FigureArea.FigureArea.TriangleSquare(nullException[0], nullException[1], nullException[2]));
    }
    [Fact]
    public void NegativeException()
    {
        Assert.Throws<ArgumentException>(() => FigureArea.FigureArea.TriangleSquare(negativeException[0], negativeException[1], negativeException[2]));
    }
    [Fact]
    public void Normal()
    {
        Assert.InRange(FigureArea.FigureArea.TriangleSquare(notException[0], notException[1], notException[2]), 0.11, 0.12);
    }
}
