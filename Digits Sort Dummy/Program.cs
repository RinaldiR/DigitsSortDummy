internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer value bigger 0");
        int inputValue = ReadInt();
        Console.WriteLine("You entered {0}", inputValue);

        // TODO: implement your program

        int actualDigit = 0;

        do
        {
            
                if (actualDigit == 0)
                {
                    actualDigit++;
                }
                else if (actualDigit == 5)
                {
                    actualDigit++;
                }
            int zahl = inputValue;
            while (zahl > 0)
            {
                int firstNumber = zahl % 10;
                zahl /= 10;
                if (firstNumber == actualDigit)
                {
                    Console.WriteLine(actualDigit);
                }

            }
            actualDigit++;
        } while (actualDigit != 9);
        
        


    }

    static int ReadInt()
    {
        int i;
        do
        {
            string s = Console.ReadLine();
            int.TryParse(s, out i);
        } while (i <= 0);
        return i;
    }

    // TODO: implement your functions

}