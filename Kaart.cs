namespace HelloWorld
{
    public class Kaart
    {
        public readonly int breedte;
        public readonly int hoogte;
        private List<KaartItem> kaartItems = new List<KaartItem>();
        private List<Pad> paden = new List<Pad>();

        public Kaart(int breedteInt, int hoogteInt)
        {
            this.breedte = breedteInt;
            this.hoogte = hoogteInt;
        }

        public void TekenConsole(ConsoleTekener t)
        {
            for (int i = 0; i < hoogte; i++)
            {
                Console.WriteLine("");
            }
            foreach (Pad pad in paden)
            {
                pad.TekenConsole(t);
            }
            foreach (KaartItem kaartItem in kaartItems)
            {
                kaartItem.TekenConsole(t);
            }

        }

        public void VoegItemToe(KaartItem item)
        {
            kaartItems.Add(item);
        }

        public void VoegPadToe(Pad pad)
        {
            paden.Add(pad);
        }
    }
}