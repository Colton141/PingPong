namespace PingPong
{
  public class PingPong
  {
    public bool IsPingPong(int num)
    {
      for (int i = 0; i <= num; i++)
      {

        if (num % 3 == 0 && num % 5 == 0)
        {
          return true;
        }
        else if (num % 5 == 0)
        {
          return true;
        }
        else if (num % 3 == 0)
        {
          return true;
        }
        else
        {
          return true;
        }
      }
    }

  }
}
