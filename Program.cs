using System;

namespace backpack_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var backpack = new Backpack("Big", "Pen");
            Console.WriteLine(backpack);
        }
    }
}
