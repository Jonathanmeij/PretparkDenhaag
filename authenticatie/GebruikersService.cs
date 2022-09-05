namespace HelloWorld
{
    class GebruikersService
    {
        public static Gebruiker Registreer(string naam, string email, string wachtwoord)
        {
            VerificatieToken verificatieToken = new VerificatieToken();
            EmailService.Email("Welkom, uw verificatiecode is: " + verificatieToken.Token, email);
            return GebruikersContext.NieuweGebruiker(naam, email, wachtwoord, verificatieToken);
        }

        public static bool Login(string email, string wachtwoord)
        {
            Gebruiker? gebruiker = GebruikersContext.GetGebruikerMetEmail(email);
            if (gebruiker == null)
            {
                return false;
            }
            //check of wachtwoord fout is
            if (gebruiker.Wachtwoord != wachtwoord)
            {
                return false;
            }
            //check of token verwijderd is
            if (gebruiker.verificatieToken != null)
            {
                return false;
            }
            return true;
        }

        public static Boolean Verifieer(string email, string token)
        {
            Gebruiker? gebruiker = GebruikersContext.GetGebruikerMetEmail(email);

            if (gebruiker == null || gebruiker.verificatieToken == null)
            {
                return false;
            }
            if (gebruiker.verificatieToken.Token == token)
            {
                gebruiker.verificatieToken = null;
                return true;
            }
            return false;
        }
    }
}