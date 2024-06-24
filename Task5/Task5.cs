namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            double GetPower(double x, int n)
            {
                if (n < 0)
                    return -1;
                if (n == 1)
                    return 1;

                double temp = GetPower(x, n / 2);
                return n % 2 == 0 ? temp * temp : x * temp * temp;
            }

            Console.WriteLine($"{GetPower(3, 2)}");
        }
    }
}
