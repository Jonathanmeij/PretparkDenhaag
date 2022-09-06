namespace HelloWorld
{
    class GebruikersContext : IGebruikersContext
    {
        private List<Gebruiker> Gebruikers = new List<Gebruiker> { };

        public int AantalGebruikers()
        {
            return Gebruikers.Count;
        }

        public Gebruiker GetGebruiker(int i)
        {
            return Gebruikers[i];
        }

        public Gebruiker? GetGebruikerMetEmail(string email)
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

        public Gebruiker NieuweGebruiker(string naam, string email, string wachtwoord)
        {
            Gebruiker nieuweGebruiker = new Gebruiker(naam, email, wachtwoord);
            Gebruikers.Add(nieuweGebruiker);
            return nieuweGebruiker;
        }
    }
}