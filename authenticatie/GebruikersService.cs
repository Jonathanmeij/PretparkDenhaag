namespace HelloWorld
{
    class GebruikersService
    {
        public IEmailService emailService;
        public IGebruikersContext gebruikersContext;
        public GebruikersService(IEmailService Imail, IGebruikersContext Igebruiker)
        {
            this.emailService = Imail;
            this.gebruikersContext = Igebruiker;
        }

        public Gebruiker Registreer(string naam, string email, string wachtwoord)
        {
            Gebruiker gebruiker = gebruikersContext.NieuweGebruiker(naam, email, wachtwoord);
            emailService.Email("Welkom, uw verificatiecode is: " + gebruiker.verificatieToken.Token, email);
            return gebruiker;
        }

        public bool Login(string email, string wachtwoord)
        {
            Gebruiker? gebruiker = gebruikersContext.GetGebruikerMetEmail(email);
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

        public Boolean Verifieer(string email, string token)
        {
            Gebruiker? gebruiker = gebruikersContext.GetGebruikerMetEmail(email);

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