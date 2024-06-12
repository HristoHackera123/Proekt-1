namespace UspehNaPichoveteOt2raGrupa9A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            List<Person> pichovete = new List<Person>();
            do
            {
                Console.Write("Input student\'s first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Input student\'s last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Input student\'s grade in bulgarian: ");
                double bg = double.Parse(Console.ReadLine());
                Console.Write("Input student\'s grade in maths: ");
                double math = double.Parse(Console.ReadLine());
                Console.Write("Input student\'s grade in history: ");
                double history = double.Parse(Console.ReadLine());
                Person person = new Person(firstName, lastName, bg, math, history);
                pichovete.Add(person);
                Console.WriteLine("would you like to put in more students?");
                answer = Console.ReadLine().ToLower();
            } while (answer == "yes");
            
            double bgSum = 0;
            double mathSum = 0;
            double historySum = 0;

            double minAvg = double.MaxValue; //<3ta zad>
            int minIdx = 0;
            double maxAvg = double.MinValue;
            int maxIdx = 0; //</3ta zad>

            for (int i = 0; i < pichovete.Count; i++)
            {
                double bg = pichovete[i].BgGrade;
                double history = pichovete[i].HistoryGrade;
                double math = pichovete[i].MathGrade;

                bgSum += bg;
                mathSum += history;
                historySum += math;

                double studentAvg = (bg + history + math) / 3; //<3ta zad>
                if (studentAvg < minAvg)
                {
                    minAvg = studentAvg;
                    minIdx = i;
                }
                if(studentAvg > maxAvg)
                {
                    maxAvg = studentAvg;
                    maxIdx = i;
                } //</3ta zad>
            }
            Console.WriteLine("             Bulgarian    Math    History");
            Console.WriteLine($"Avg grades:  {bgSum/pichovete.Count:f2}         {mathSum/pichovete.Count:f2}    {historySum/pichovete.Count:f2}");
            Console.WriteLine($"Student with the lowest average grades: {pichovete[minIdx].FirstName} {pichovete[minIdx].LastName} #{minIdx + 14}, with a {minAvg:f2}"); //<3ta zad>
            Console.WriteLine($"Student with the highest average grades: {pichovete[maxIdx].FirstName} {pichovete[maxIdx].LastName} #{maxIdx + 14}, with a {maxAvg:f2}"); //</3ta zad>

        }
    }
}
