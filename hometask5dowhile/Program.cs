namespace hometask5dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strings1;
            string strings2;
            int number1;



            do
            {
                Console.WriteLine("Enter number: ");
                strings1 = Console.ReadLine();
                number1 = Int32.Parse(strings1);

                if (!(number1 > 10 && number1 < 20))
                {
                    Console.WriteLine("The mode is incorrect.Do you want to continue?");
                    strings2 = Console.ReadLine();
                    if (strings2 == "YES")
                    {
                        continue;
                    }
                }
                else
                {
                    if (number1 % 2 == 1)
                    {
                        Console.WriteLine($"Number {number1} odd");
                    }
                    else
                    {
                        Console.WriteLine($"Number {number1} even");
                    }
                }
                break;
            } while (!(number1 >=11 && number1< 20));
        }
    }
}