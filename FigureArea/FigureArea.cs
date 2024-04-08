namespace FigureArea
{
    public static class FigureArea
    {
       public static float CircleSquare(float radius)
        {
            return MathF.Pow(radius, 2) * (float) Math.PI;
        }
        public static float TriangleSquare(float a, float b, float c)
        {
            float P = a + b + c;
            float p = P / 2;
            float SquareS = p*(p - a) * (p - b)*(p - c);
            float S=(float)Math.Sqrt(SquareS);
            return S;
        }
    }
}
