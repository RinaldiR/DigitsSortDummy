﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer value bigger 0");
        int inputValue = ReadInt();
        Console.WriteLine("You entered {0}", inputValue);

        // TODO: implement your program

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