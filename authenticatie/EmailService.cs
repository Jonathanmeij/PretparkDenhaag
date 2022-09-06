namespace HelloWorld
{
    class EmailService : IEmailService
    {
        public void Email(string text, string naarAdres)
        {
            Console.WriteLine("Aan: " + naarAdres);
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
        }
    }
}