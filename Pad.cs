namespace HelloWorld
{
    public class Pad
    {
        private float? lengteBerekend;
        private Coordinaat _van;
        public Coordinaat van
        {
            get { return this._van; }
            set
            {
                this._van = value;
                lengteBerekend = 0;
            }
        }
        private Coordinaat _naar;
        public Coordinaat naar
        {
            get { return this._naar; }
            set
            {
                this._naar = value;
                lengteBerekend = 0;
            }
        }


        public float Lengte()
        {
            float berekend = (float)Math.Sqrt(Math.Pow((naar.x - van.x), 2) + Math.Pow((naar.y - van.y), 2)) * 1000;
            return berekend;
        }

        public float Afstand(Coordinaat c)
        {
            return 0;
        }

        public void TekenConsole(ConsoleTekener t)
        {
            int dx = Math.Abs(naar.x - van.x);
            int dy = Math.Abs(naar.y - van.y);
            int x = van.x;
            int y = van.y;
            int n = 1 + dx + dy;
            int x_inc = (naar.x > van.x) ? 1 : -1;
            int y_inc = (naar.y > van.y) ? 1 : -1;
            int error = dx - dy;
            dx *= 2;
            dy *= 2;

            for (; n > 0; --n)
            {
                t.SchrijfChar(new Coordinaat(x, y), '#');


                if (error > 0)
                {
                    x += x_inc;
                    error -= dy;
                }
                else
                {
                    y += y_inc;
                    error += dx;
                }
            }

            int avgX = (int)(van.x + naar.x) / 2;
            int avgY = (int)(van.y + naar.y) / 2;
            t.SchrijfOp(new Coordinaat(avgX, avgY), Lengte().metSuffixen());

        }

        public void raytrace(float x0, float y0, float x1, float y1)
        {

        }
    }
}