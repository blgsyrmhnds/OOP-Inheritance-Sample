namespace OOPDersKalıtım
{
     public class IkiBoyut
    {

         //Constructor ile x,y parametreleri ile sınıf oluşuyor.
         public IkiBoyut(int x, int y)
         {
             X = x;
             Y = y;
         }

         public int X { get; set; }
         public int Y { get; set; }


         #region Overrides


         //Object sınıfının ToString() metodu override ediliyor.
         public override string ToString()
         {
             return string.Format("X = {0}, Y = {1}", X, Y);
         }

        #endregion

         //propertylerin değerleri toplanıyor.
         public virtual int KoordinatToplam()
         {
             return X + Y;
         }

    }
}
