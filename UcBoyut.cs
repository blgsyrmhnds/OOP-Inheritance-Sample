namespace OOPDersKalıtım
{
    public class UcBoyut : IkiBoyut
    {

        //ucboyut constructor default değerleri 0,
        //x ve y değerleri ile kalıtım alınan ikiboyut sınıfının constructor u çağırıyor.
        //ve kendi Z propertysinin değerini atıyor.
        public UcBoyut(int x = 0,int y = 0,int z = 0) : base(x,y)
        {
            Z = z;
        }
        public int Z { get; set; }


        #region override

        //base ikiboyut nesnemizin ToString() metodu override ediliyor. 
        //Base deki ToString çağırılıyor ve üzerine Z ekleniyor
        public override string ToString()
        {
            return string.Format("{0}, Z = {1}",base.ToString(),Z);
        }

        //base deki koordinatToplam metodu override ediliyor ve ordan dönen değere z ekleniyor.
        public override int KoordinatToplam()
        {
            return base.KoordinatToplam() + Z;
        }

        #endregion

        //ikiboyut nesnesinden üç boyut nesnesi oluşturmak için statik method.
        public static UcBoyut FromIkiBoyut(IkiBoyut ikiBoyut)
        {

            //default değerler 0 olduğu için yeni ucboyut nesnemizin tüm parametrelerini vermek zorunda değiliz.
            return  new UcBoyut(ikiBoyut.X,ikiBoyut.Y);
        }
    }
}
