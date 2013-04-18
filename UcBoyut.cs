namespace OOPDersKalıtım
{
    public class UcBoyut : IkiBoyut
    {
        public UcBoyut(int x = 0,int y = 0,int z = 0) : base(x,y)
        {
            Z = z;
        }
        public int Z { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, Z = {1}",base.ToString(),Z);
        }

        public override int KoordinatToplam()
        {
            return base.KoordinatToplam() + Z;
        }

        public static UcBoyut FromIkiBoyut(IkiBoyut ikiBoyut)
        {
            return  new UcBoyut(ikiBoyut.X,ikiBoyut.Y);
        }
    }
}
