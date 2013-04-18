using System;

namespace OOPDersKalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 boyut sınıfımızı constructor ile oluşturuyoruz.
            var ikiBoyut = new IkiBoyut(10, 40);

            //ikiboyut nesnemizin override edilmiş ToString metodu yazdırılıyor.
            Console.WriteLine(ikiBoyut.ToString());

            //ikiboyut nesnemizin KoordinatToplam metodu yazdırılıyor.
            Console.WriteLine(ikiBoyut.KoordinatToplam());

            //ikiboyutl nesnemizden ucboyut nesnesi oluşturuyoruz.
            var ucBoyut = UcBoyut.FromIkiBoyut(ikiBoyut);

            //default değer 0 olan z property değeri değiştiriliyor.
            ucBoyut.Z = 50;

            //ucboyut override edilmiş ToString metodu yazdırılıyor.
            Console.WriteLine(ucBoyut.ToString());

            //ucboyut nesnemizin kordinat toplamı yazdırılıyor.
            Console.WriteLine(ucBoyut.KoordinatToplam());

            Console.ReadKey();

        }
    }
}
