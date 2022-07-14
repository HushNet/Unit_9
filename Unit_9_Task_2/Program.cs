using Unit_9_Task_2;

namespace Unit_9_Task_2;

public delegate void NumEnteredDelegate(int num, List<string> names);

public class Program
{
    public static event NumEnteredDelegate NumEnteredEvent;

    static void Main(string[] args)
    {
        MyException myException = new MyException("Некорректное число!");
        List<string> lastNames = new List<string>() { "Alex", "Boolex", "Zoro", "Aang" };

        NumEnteredEvent += SortNames;

        while (true)
        {
            try
            {
                Console.WriteLine($"Введите число 1 или 2: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num != 1 && num != 2)
                {
                    throw myException;
                }

                NumEnteredEvent(num, lastNames);

                foreach (var name in lastNames)
                {
                    Console.WriteLine(name);
                }
            }
            catch (Exception me)
            {
                Console.WriteLine(me.Message);
            }
        }
    }

    public static void SortNames(int num, List<string> names)
    {
        switch (num)
        {
            case 1:
                names.Sort();
                break;
            case 2:
                names.Sort();
                names.Reverse();
                break;
        }
    }
}