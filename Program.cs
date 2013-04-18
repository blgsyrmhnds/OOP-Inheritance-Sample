using System;

namespace OOPDersKalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            var ikiBoyut = new IkiBoyut(10, 40);
            Console.WriteLine(ikiBoyut.ToString());
            Console.WriteLine(ikiBoyut.KoordinatToplam());

            var ucBoyut = UcBoyut.FromIkiBoyut(ikiBoyut);
            ucBoyut.Z = 50;
            Console.WriteLine(ucBoyut.ToString());
            Console.WriteLine(ucBoyut.KoordinatToplam());

            Console.ReadKey();

        }
    }
}
