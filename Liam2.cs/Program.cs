using System;

namespace Liam2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            info.setFirstName("Jim");
            info.setLastName("Bim");
            Console.WriteLine(info.getFirstName() + " " + info.getLastName());
        }
    }
}
