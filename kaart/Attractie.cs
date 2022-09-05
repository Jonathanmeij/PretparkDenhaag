namespace HelloWorld
{
    class Attractie : KaartItem
    {
        private Coordinaat Coordinaat;
        private int? _minimaleLengte;
        private int _angstLevel;

        public Attractie(Kaart kaart, Coordinaat coordinaat) : base(kaart, coordinaat) { }

        public override char karakter { get { return 'A'; } }
    }
}