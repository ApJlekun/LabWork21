namespace Task3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
        }

        string GetSize(int bytes)
        {
            return (bytes < (1 << 10)) ? $"{bytes} Б" :
                   (bytes < (1 << 20)) ? $"{bytes >> 10} КБ" :
                   (bytes < (1 << 30)) ? $"{bytes >> 20} МБ" :
                   $"{bytes >> 30} ГБ";
        }
    }
}
