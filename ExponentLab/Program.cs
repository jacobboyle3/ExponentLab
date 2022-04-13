public class Program
{
    public static void Main()
    {
        Console.WriteLine("Let's learn number squares and cubes!");
        int maxNum;
        do
        {
            Console.WriteLine("Please enter an integer: ");

            maxNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxNum; i++)
            {
                if (i == 1)
                    Console.WriteLine("number".PadRight(9) + "squared".PadRight(9) + "cubed" + " \n======== ======= =======");

                Console.WriteLine(i.ToString().PadRight(8) +
                    " " + Math.Pow(i, 2).ToString().PadRight(8) +
                    " " + Math.Pow(i, 3).ToString());
            }

            Console.WriteLine("Would you like to enter another number? y/n");

        } while (Console.ReadLine().ToLower() == "y");
    }
}