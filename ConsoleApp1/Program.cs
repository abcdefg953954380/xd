class Program
{
    static void Main(string[] args)
    {
        abc();
    } 
    static void abc()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        int a = 1;

        while (a < 5)
        {
            Console.WriteLine("abcdefg");
            a++;
        }

        string napis = "abcl";
        int licznik = 0;

        foreach (char l in napis)
        {
            licznik++;
        }
    }
}