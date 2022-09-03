namespace HelloWorld
{
    public abstract class KaartItem
    {
        private Coordinaat _locatie;
        private Kaart kaart;
        public Coordinaat locatie
        {
            get { return this._locatie; }
            set
            {
                if (value.x < 0 || value.y < 0)
                    throw new Exception("locatie is negatief");
                else if (value.x > kaart.breedte || value.y > kaart.hoogte)
                    throw new Exception("locatie is buiten de kaart");
                else
                    this._locatie = value;
            }
        }
        public KaartItem(Kaart kaart, Coordinaat _locatie)
        {
            this.kaart = kaart;
            this._locatie = _locatie;
        }

        public void TekenConsole(ConsoleTekener t)
        {
            t.SchrijfChar(_locatie, karakter);
        }

        public abstract char karakter { get; }
    }
}