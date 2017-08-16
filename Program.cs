using System;

namespace backpack_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var backpack = new Backpack("Big", "Pen");
            backpack.AddTrackedItem("Pen");
            backpack.AddTrackedItem("Pen");
            backpack.AddTrackedItem("Ipod");
            // backpack.RemoveTrackedItem("Pen");
            Console.WriteLine(backpack);
            backpack = new Backpack("Small", "Folder");
            Console.WriteLine(backpack);
        }
    }
}
