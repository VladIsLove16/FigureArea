namespace FigureArea
{
    public static class FigureArea
    {
       public static float CircleSquare(float radius)
        {
            return MathF.Pow(radius, 2) * (float) Math.PI;
        }
    }
}
