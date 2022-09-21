namespace FigureLib
{
    public class Area
    {
        public static double AreaTriangle(double a, double b, double c)  //площадь треугольника
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double AreaCircle(double r) //площадь круга
        {            
            return Math.PI * Math.Pow(r, 2);
        }
        
        public static void SquarenessCheck(double a, double b, double c) //проверка треугольника на прямоульность
        {
            if (c * c == a * a + b * b)
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник непрямоугольный");
            }
        }
    }
}