namespace FigureArea
{
    public static class FigureArea
    {
       public static float CircleSquare(float radius)
        {
            if (radius<0)
                throw new ArgumentException("Длина радиуса должна быть положительна");
            return MathF.Pow(radius, 2) * (float) Math.PI;
        }
        public static float TriangleSquare(float a, float b, float c)
        {
            if( a<= 0 || b<=0 || c <=0)
                throw new ArgumentException("Все стороны должны иметь положительную длину");
            char flag = ' ';
            if ((a + b) <= c)
                flag = 'c';
            else if ((a + c) <= b)
                flag = 'b';
            else if ((b + c) <= a)
                flag = 'a';
            if (flag != ' ')
                throw new ArgumentException($"Сторона {flag} больше суммы двух других");
            bool SquareTriangle = false;
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
                SquareTriangle = true;
            if (SquareTriangle) Console.WriteLine($"Треугольник {a} {b} {c} прямоугольный");
            float P = a + b + c;
            float p = P / 2;
            float SquareS = p*(p - a) * (p - b)*(p - c);
            float S=(float)Math.Sqrt(SquareS);
            return S;
        }

    }
}
