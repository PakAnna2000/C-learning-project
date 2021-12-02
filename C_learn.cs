using System;

namespace C_learn // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void menuLine(int i, string str) //function to make line in
        //"i. str: " format
        {
            Console.WriteLine(i + ". " + str + ": ");
        }
        public static string? stringInput(string str) // for string input
        {
            Console.Write(str + ": ");      
            string? input = Console.ReadLine();  
            return input;
        }
        public static int intInput(string str) // for int input
        {
            Console.Write(str + ": ");      
            return int.Parse(Console.ReadLine()); // converting string to int
        }
        public static void drawLine(int size) // draw +----+
        {
            Console.Write("+");
            for (int i = 0; i < size + 2; i++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
        }
        public static void decorate(string str) // make borders
        {
            int size = str.Length;
            drawLine(size);
            Console.WriteLine("| " + str + " |");
            drawLine(size);
        }
        public static void saturnalia() // 1. Saturnalia
        {
            int lineNum = intInput("Lines");
            string[] lines = new string[lineNum];
            for(int i = 0; i < lineNum; i++) 
            {
                lines[i] = stringInput((i+1).ToString());
            }
            for(int i = 0; i < lineNum; i++)
            {
                Console.WriteLine("Case #" + (i + 1));
                decorate(lines[i]);
            }
        }
        public static void Main(string[] args)
        {
            int progNumber = 1;
            switch(progNumber)
            {
                case 1: 
                {
                    //Saturnalia
                    menuLine(progNumber, "Saturnalia");
                    saturnalia();
                    break;
                }
                default: break;
            }
        }
    }
}