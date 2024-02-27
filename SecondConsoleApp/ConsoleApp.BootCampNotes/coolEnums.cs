namespace coolName
{
  public class coolEnums
  {
    public static void ain()
    {
      System.Console.WriteLine("bu bir balkar class ");
    }

    enum Level
    {
      Low,
      Medium,
      High
    }
    static void enumLister()
    {
      Level myVar = Level.Medium;
      Console.WriteLine(myVar);
      Level mySecondVar = Level.High;
    }


  }
}