namespace Library
{
    public class DataService
    {
        public bool Metod1(double x, double y)
        {
            bool res = false;
            if (((x >= 0 && y >= 0) && ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 0.09)) | (y < 0))
            {
                res = false;
                
            }
            else
            {
                res = true;
                
            }
            return res;
        }

    }
}
