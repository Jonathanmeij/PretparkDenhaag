namespace HelloWorld
{
    class VerificatieToken
    {
        public string Token { get; set; }
        public DateTime VerloopDatum { get; set; }
        private static Random random = new Random();

        public VerificatieToken()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            this.Token = randomString;
        }
    }
}