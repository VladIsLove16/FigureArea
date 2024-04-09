using FigureArea;
using Xunit;

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
public class IShapeTest()
{
    float radius=0.8f;
    float[] triangle = [1.2f, 0.3f, 1.15f];
    IShape shape;
    [Fact]
    public void CircleTypeTest()
    {
        shape = new Circle(radius);
        Assert.IsType<Circle>(shape);
    }
    [Fact]
    public void TriangleTypeTest()
    {
        shape = new Triangle(triangle[0], triangle[1], triangle[2]);
        Assert.IsType<Triangle>(shape);
    }
    [Fact]
    public void CircleCalculationTest()
    {
        shape = new Circle(radius);
        Assert.InRange(shape.CalculateArea(), 2.0f, 2.1f);
    }
    [Fact]
    public void TriangleCalculationTest()
    {
        shape = new Triangle(triangle[0], triangle[1], triangle[2]);
        Assert.InRange(shape.CalculateArea(), 0.1, 0.2);
    }

}
