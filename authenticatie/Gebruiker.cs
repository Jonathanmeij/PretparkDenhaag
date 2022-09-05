namespace HelloWorld
{
    class Gebruiker
    {
        public string Naam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public VerificatieToken? verificatieToken { get; set; }

        public Gebruiker(string naam, string email, string wachtwoord, VerificatieToken verificatieToken)
        {
            this.Naam = naam;
            this.Email = email;
            this.Wachtwoord = wachtwoord;
            this.verificatieToken = verificatieToken;
        }
        public bool Geverifieerd()
        {
            if (verificatieToken == null)
            {
                return true;
            }
            return false;
        }

    }
}