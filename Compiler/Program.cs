using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Compiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ask user
            Console.WriteLine("Welcome To Compiler!\n");
            Console.WriteLine("0: Create File\n");
            Console.WriteLine("1: Read File\n");

            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                // null OR ""
                Console.WriteLine("Invalid Input\n");
                Console.WriteLine("Closing Program...\n");
                input = Console.ReadLine();
                return;
            }

            // --==--==--==--==--==
            // Let's just create a file for Now ---

            if (input == "0")
            {
                // CreateFile.FileCreationMain();
            }
            else if (input == "1")
            {
                // ReadFile.FileReadMain();
            }

            CreateFile.FileCreationMain();


        }
    }
}
