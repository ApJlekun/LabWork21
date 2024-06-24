namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            // вычисление площади кольца
            double r1 = 4;
            double r2 = 2;

            double s = Math.Abs(Math.PI * ((r1 - r2) * (r1 + r2)));

            // сумма чисел от 1 до n (заменить на сумму ряда натуральных чисел)
            int n = 10;
            int sum = (1 + n) * n / 2;
        }
    }
}
