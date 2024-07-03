using Tynamix.ObjectFiller;

namespace RandomDataGeneratorProgram.Services;

internal class RandomDataGeneratorService
{
    public void GenerateEmailAddress(int count)
    {
        EmailAddresses emailAddresses = new EmailAddresses();

        for (int i = 0; i < count; i++)
        {
            string emailRandom = emailAddresses.GetValue();
            Console.WriteLine(emailRandom);
        }
    }
    public void GenerateRealName(int count)
    {
        RealNames realNames = new RealNames();

        for (int i = 0; i < count; i++)
        {
            string nameRandom = realNames.GetValue();
            Console.WriteLine(nameRandom);
        }
    }
    public void GenerateParagraph(int count)
    {
        Lipsum lipsum = new Lipsum();

        for (int i = 0; i < count; i++)
        {
            string lipsumRandom = lipsum.GetValue();
            Console.WriteLine(lipsumRandom);
        }
    }
    public void GenerateCountryName(int count)
    {
        CountryName countryName = new CountryName();

        for (int i = 0; i < count; i++)
        {
            string countryRandom = countryName.GetValue();
            Console.WriteLine(countryRandom);
        }
    }
}
