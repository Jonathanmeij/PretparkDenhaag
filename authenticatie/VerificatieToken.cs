namespace HelloWorld
{
    class VerificatieToken
    {
        public string Token { get; set; }
        public DateTime VerloopDatum { get; set; }

        public VerificatieToken(string Token, DateTime VerloopDatum)
        {
            this.Token = Token;

            TimeSpan time = new TimeSpan(3, 0, 0, 0);
            DateTime combined = VerloopDatum.Add(time);
            this.VerloopDatum = combined;
        }
    }
}