namespace HelloWorld
{
    class Gebruiker
    {
        public string Naam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public VerificatieToken? verificatieToken { get; set; }
        private static Random random = new Random();

        public Gebruiker(string naam, string email, string wachtwoord)
        {
            this.Naam = naam;
            this.Email = email;
            this.Wachtwoord = wachtwoord;

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            VerificatieToken verificatieToken = new VerificatieToken(randomString, DateTime.Now);

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