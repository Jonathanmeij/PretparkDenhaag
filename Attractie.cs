namespace HelloWorld
{
    class Attractie : KaartItem
    {
        private Kaart kaart;
        private Coordinaat Coordinaat;
        private int? _minimaleLengte;
        private int _angstLevel;
        private string naam;

        public Attractie(Kaart kaart, Coordinaat coordinaat) : base(kaart, coordinaat) { }

        public override char karakter { get { return 'A'; } }
    }
}