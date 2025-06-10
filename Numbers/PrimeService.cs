namespace System.Numbers
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            for (int divisor = 2; divisor <= Math.Sqrt(candidate); ++divisor)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }


        // Dummy method to remove 100 percent code coverage. Comment out this method if needed to achieve 100 percent coverage.
      //  public bool IsEven(int number)
      //  {
      //      if (number == 0)
      //      {
      //          return true;
      //      }
      //      return number % 2 == 0;
      //  }
    }
}