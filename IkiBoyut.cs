namespace OOPDersKalıtım
{
     public class IkiBoyut
    {
         public IkiBoyut(int x, int y)
         {
             X = x;
             Y = y;
         }

         public int X { get; set; }
         public int Y { get; set; }


         #region Overrides

         public override string ToString()
         {
             return string.Format("X = {0}, Y = {1}", X, Y);
         }

        #endregion

         public virtual int KoordinatToplam()
         {
             return X + Y;
         }

    }
}
