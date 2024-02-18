using System;
namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                
                Console.WriteLine("Wpisz proszę aktualną temperaturę");
                Console.WriteLine("Temperatura");
                int a = 0;

                int.TryParse(Console.ReadLine(), out a);
                
                {
                    if (a < 0)
                    {
                        Console.WriteLine("Cholernie piździ:");
                    }
                    else if (a <= 9)
                    {
                        Console.WriteLine("Zimno:");
                    }
                    else if (a<=20)
                    {
                        Console.WriteLine("Chłodno:");
                    }
                    else if (a<=30)
                    {
                        Console.WriteLine("W sam raz:");
                    }
                    else if (a <=40)
                    {
                        Console.WriteLine("Zaczyna być słabo, bo gorąco:");
                    }
                    else if (a >41)
                    {
                        Console.WriteLine("A weź wyprowadzam sie na Alaskę.");
                    }
                }
                
                
            }
        }
    }
}