using System.IO;
using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Hello, World!");
        Klass MyKlass = new Klass();
        
        // send this data to the new object(class)
        MyKlass.NewData = "there and back!";
        Console.WriteLine(MyKlass.passItOn());
        
    }
}


class Klass
{
    private static string moreInformation;
    
    //default constructor
    public Klass()
    {}
    
    public Klass(string x)
    {
        moreInformation = x;
    }
    
    public string passItOn()
    {
        string passBack;
        
        passBack = moreInformation + " from the Klass! ";
        
        return passBack;
    }
    
    //property
    public string NewData
    {
        get
        {
            return moreInformation;
        }
        set
        {
            moreInformation = value;
        }
    }
}