namespace HelloWorld
{
    public struct Coordinaat
    {
        public readonly int x;
        public readonly int y;

        public Coordinaat(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Coordinaat operator +(Coordinaat a, Coordinaat b)
        {
            var x = a.x + b.x;
            var y = a.y + b.y;
            return new Coordinaat(x, y);
        }
    }
}