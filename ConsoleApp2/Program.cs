using System;
using System.Xml;

internal class Program
{
    static string message = "";
    private static void Main(string[] args)
    {
        do {
            Console.WriteLine("Please give me something to encode");
             message = Console.ReadLine();
            string output = "";
            for (int i = 0; i < message.Length; i++)
            {
                int v = (int)message[i];

                if (v >= 48 && v <= 57)
                {
                    v -= 48;
                    v += 5;
                    v %= 10;
                    v += 48;
                    output += (char)v;
                }
                else if (v >= 65 && v <= 90)
                {
                    v -= 65;
                    v += 13;
                    v %= 26;
                    v += 65;
                    output += (char)v;
                }
                else if (v >= 97 && v <= 122)
                {
                    v -= 97;
                    v += 13;
                    v %= 26;
                    v += 97;
                    output += (char)v;
                }
                else
                {
                    output += (char)v;
                }
                
            }
            Console.WriteLine(output);
        } while (message !="") ;
        
    }
}
