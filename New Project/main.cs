using System.IO;
using System;

class Program
{
    static void Main()
    {
        string name;
        
        Console.WriteLine("Type in your name:");
        name = Console.ReadLine();
        
        Console.WriteLine("Hello, World!");
        display();
        Console.WriteLine("from main {0} :", firstMethod(name));
    }
    
    static void display()
    {
        Console.WriteLine("this is all the information that I have");
    }
    
    static int firstMethod(string name)
    {
        int x = 2;
        int y = 4;
        int ans;
        
        Console.WriteLine("from the method: {0}", ans = x + y);
        Console.WriteLine("The name that you requested is: {0} ", name);
        
        if (name == "alex")
        {
            Console.WriteLine("hey! I know you...");
        }
        else
        {
            Console.WriteLine("I don't know you but have a nice day!");
        }
        return ans;
    }
}
