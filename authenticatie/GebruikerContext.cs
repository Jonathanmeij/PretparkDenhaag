namespace HelloWorld
{
    class GebruikersContext
    {
        private static List<Gebruiker> Gebruikers = new List<Gebruiker> { };

        public static int AantalGebruikers()
        {
            return Gebruikers.Count;
        }

        public static Gebruiker GetGebruiker(int i)
        {
            return Gebruikers[i];
        }

        public static Gebruiker? GetGebruikerMetEmail(string email)
        {
            foreach (Gebruiker g in Gebruikers)
            {
                if (g.Email == email)
                {
                    return g;
                }
            }
            return null;
        }

        public static Gebruiker NieuweGebruiker(string naam, string email, string wachtwoord, VerificatieToken verificatieToken)
        {
            Gebruiker nieuweGebruiker = new Gebruiker(naam, email, wachtwoord, verificatieToken);
            Gebruikers.Add(nieuweGebruiker);
            return nieuweGebruiker;
        }
    }
}