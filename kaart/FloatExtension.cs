namespace HelloWorld
{
    public static class FloatExtension
    {
        public static string metSuffixen(this float value)
        {
            if (value < 1000000)
            {
                return (int)value / 1000 + "k";
            }
            else if (value < 1000000000)
            {
                return (int)value / 1000000 + "m";
            }
            else
            {
                return (int)value / 1000000000 + "b";
            }
        }
    }
}