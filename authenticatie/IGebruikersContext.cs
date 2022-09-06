namespace HelloWorld
{
    interface IGebruikersContext
    {
        int AantalGebruikers();
        Gebruiker GetGebruiker(int i);
        Gebruiker? GetGebruikerMetEmail(string email);
        Gebruiker NieuweGebruiker(string naam, string email, string wachtwoord);
    }
}