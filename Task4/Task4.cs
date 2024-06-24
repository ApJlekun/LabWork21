namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            int GetDaysCount(int month, int year)
            {
                if (month < 1 || month > 12 || year < 0)
                    return -1;

                int[] daysInMonth = { 31, 28 + (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0) ? 1 : 0), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                return daysInMonth[month - 1];
            }
        }
    }
}
