namespace HelloWorld
{
    class EmailService
    {
        public static void Email(string text, string naarAdres)
        {
            Console.WriteLine("Aan: " + naarAdres);
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
        }
    }
}