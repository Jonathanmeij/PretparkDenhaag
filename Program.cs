namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kaart k = new Kaart(30, 30);
            // Pad p1 = new Pad();
            // p1.van = new Coordinaat(2, 1);
            // p1.naar = new Coordinaat(12, 30);
            // k.VoegPadToe(p1);
            // Pad p2 = new Pad();
            // p2.van = new Coordinaat(26, 4);
            // p2.naar = new Coordinaat(10, 5);
            // k.VoegPadToe(p2);
            // k.VoegItemToe(new Attractie(k, new Coordinaat(15, 15)));
            // k.VoegItemToe(new Attractie(k, new Coordinaat(20, 15)));
            // k.VoegItemToe(new Attractie(k, new Coordinaat(5, 18)));
            // k.TekenConsole(new ConsoleTekener());
            // new ConsoleTekener().SchrijfOp(new Coordinaat(0, k.hoogte + 1), "Deze kaart is schaal 1:1000");
            // System.Console.Read();

            menu();
        }

        static void menu()
        {
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("1) Inloggen");
                Console.WriteLine("2) Registreren");
                Console.WriteLine("3) Verifieren");
                Console.WriteLine("0) Exit");
                Console.Write("\r\nKies een optie: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        Registreer();
                        break;
                    case "3":
                        Verifieren();
                        break;
                    case "0":
                        menu = false;
                        break;
                }
                Console.Write("\r\nDruk op enter om terug te keren: ");
                Console.ReadLine();
            }
        }

        static void Login()
        {
            Console.WriteLine("Email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Wachtwoord:");
            string Wachtwoord = Console.ReadLine();
            bool ingelogd = GebruikersService.Login(Email, Wachtwoord);
            if (ingelogd)
            {
                Console.WriteLine("\r\nsuccesvol ingelogd\r\n");
                return;
            }
            Console.WriteLine("\r\ninloggen mislukt\r\n");
            return;
        }

        static void Registreer()
        {
            Console.WriteLine("\r\nNaam:");
            string Naam = Console.ReadLine();
            Console.WriteLine("\r\nEmail:");
            string Email = Console.ReadLine();
            Console.WriteLine("\r\nWachtwoord:");
            string Wachtwoord = Console.ReadLine();

            Gebruiker gebruiker = GebruikersService.Registreer(Naam, Email, Wachtwoord);
            if (gebruiker != null)
            {
                Console.WriteLine("\r\nsuccesvol aangemeld!\r\n");
                return;
            }
            Console.WriteLine("\r\nRegistreren mislukt.\r\n");
            return;
        }

        static void Verifieren()
        {
            Console.WriteLine("\r\nEmail:");
            string Email = Console.ReadLine();
            Console.WriteLine("\r\nToken:");
            string Token = Console.ReadLine();

            if (GebruikersService.Verifieer(Email, Token))
            {
                Console.WriteLine("\r\nVerificatie voltooid\r\n.");
                return;
            }
            Console.WriteLine("\r\nVerificatie mislukt.\r\n");

        }
    }
}