using System.Globalization;
using System.Net.Sockets;
using System.Security.Cryptography;
using Spectre.Console;

class Program
{
    public static void Main()
    {
        string[] array = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

        for(int sum = 0; sum < 9; )
        {
            if(sum < 9)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {array[0]}  |  {array[1]}  |  {array[2]} ");
                Console.WriteLine("-----|-----|-----");
                Console.WriteLine($"  {array[3]}  |  {array[4]}  |  {array[5]} ");
                Console.WriteLine("-----|-----|-----");
                Console.WriteLine($"  {array[6]}  |  {array[7]}  |  {array[8]} ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" X: ");
                int x = int.Parse(Console.ReadLine()!);

                for(int a = 0; a < array.Length; a++)
                {
                    Console.Clear();
                    
                    if(array[a] == x.ToString())
                    {
                        array[a] = "X";
                        Console.ForegroundColor = ConsoleColor.Blue;
                        if(array[0] == array[1] && array[0] == array[2] 
                        || array[0] == array[3] && array[0] == array[6] 
                        || array[0] == array[4] && array[0] == array[8] 
                        || array[1] == array[4] && array[1] == array[7] 
                        || array[3] == array[4] && array[3] == array[5] 
                        || array[6] == array[4] && array[6] == array[2] 
                        || array[6] == array[7] && array[6] == array[8] 
                        || array[2] == array[5] && array[2] == array[8])
                        {
                            AnsiConsole.Write(
                            new FigletText("X WIN")
                            .Centered()
                            .Color(Color.Blue1));
                            sum += 10;
                            break;
                        }
                        sum++;
                    }
                }
            }
            
            if(sum < 9)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {array[0]}  |  {array[1]}  |  {array[2]} ");
                Console.WriteLine("-----|-----|-----");
                Console.WriteLine($"  {array[3]}  |  {array[4]}  |  {array[5]} ");
                Console.WriteLine("-----|-----|-----");
                Console.WriteLine($"  {array[6]}  |  {array[7]}  |  {array[8]} ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" O: ");

                int o = int.Parse(Console.ReadLine()!);

                for(int a = 0; a < array.Length; a++)
                {
                    Console.Clear();

                    if(array[a] == o.ToString())
                    {
                        array[a] = "O";
                        if(array[0] == array[1] && array[0] == array[2] 
                        || array[0] == array[3] && array[0] == array[6] 
                        || array[0] == array[4] && array[0] == array[8] 
                        || array[1] == array[4] && array[1] == array[7] 
                        || array[3] == array[4] && array[3] == array[5] 
                        || array[6] == array[4] && array[6] == array[2] 
                        || array[6] == array[7] && array[6] == array[8] 
                        || array[2] == array[5] && array[2] == array[8])
                        {
                            AnsiConsole.Write(
                            new FigletText("O WIN")
                            .Centered()
                            .Color(Color.Red1));
                            sum += 10;
                            break;
                        }
                        sum++;
                    }
                }
            }
            
            if(sum == 9)
            {
                AnsiConsole.Write(
                new FigletText("DRAW")
                .Centered()
                .Color(Color.Green));
            }


        }

         
    }
}