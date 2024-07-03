using RandomDataGeneratorProgram.Models;
using RandomDataGeneratorProgram.Services;

namespace RandomDataGeneratorProgram;

internal class Program
{
    static void Main(string[] args)
    {
        StartProgram();
    }

    static void StartProgram()
    {
        RandomDataGeneratorService randomDataGeneratorService = new RandomDataGeneratorService();
        RandomDataGenerator randomDataGenerator;

        while (true)
        {

            Console.Clear();
            string choice;
            Console.WriteLine("1. RandomEmail ");
            Console.WriteLine("2. RandomName ");
            Console.WriteLine("3. RandomParagraph ");
            Console.WriteLine("4. RandomCountryName ");
            Console.Write("Enter : ");
            choice = Console.ReadLine();


            if (choice == "1")
            {
                Console.WriteLine(" How much do you want to get RandomEmail ");
                Console.Write(" Enter : ");
                int setNumber = int.Parse(Console.ReadLine());
                randomDataGeneratorService.GenerateEmailAddress(setNumber);
            }
            if (choice == "2")
            {
                Console.WriteLine(" How much do you want to get RandomName ");
                Console.Write(" Enter : ");
                int setNumber = int.Parse(Console.ReadLine());
                randomDataGeneratorService.GenerateRealName(setNumber);
            }
            if (choice == "3")
            {
                Console.WriteLine(" How much do you want to get RandomParagraph ");
                Console.Write(" Enter : ");
                int setNumber = int.Parse(Console.ReadLine());
                randomDataGeneratorService.GenerateParagraph(setNumber);
            }
            if (choice == "4")
            {
                Console.WriteLine(" How much do you want to get RandomCountryName ");
                Console.Write(" Enter : ");
                int setNumber = int.Parse(Console.ReadLine());
                randomDataGeneratorService.GenerateCountryName(setNumber);
            }
            string option;
            Console.Write("Do you want to continue   Y/N :");
            option = Console.ReadLine();
            string[] options = { "Yes", "Y", "yes", "YES", "y" };
            bool check = options.Any(o => o == option);
            if (!check) break;
        }
    }
}
