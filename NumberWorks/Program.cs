namespace NumberWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a random num (up to 6 digits)");
            List<int> figures = new List<int>();
            try
            {
                int num = int.Parse(Console.ReadLine());

                int cycles = -1;
                while (num > 0)
                {
                    cycles++;
                    if (cycles > 5)
                    {
                        throw new ArgumentException();
                    }
                    int last = num % 10;
                    num = num / 10;
                    figures.Add(last);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You can only input up to 6-digit numbers");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input number should be... a number");
                return;
            }

            int evenSum = 0;
            int oddCount = 0;
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i] % 2 == 0)
                {
                    evenSum += figures[i];
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine($"Sum of the even numbers = {evenSum}");
            Console.WriteLine($"Count of the odd numbers = {oddCount}");
        }
    }
}
