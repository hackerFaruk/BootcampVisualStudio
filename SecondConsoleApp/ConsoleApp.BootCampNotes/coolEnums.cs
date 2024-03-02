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
    public static void enumLister()
    {
      Level myVar = Level.Medium;
      Console.WriteLine(myVar);
      int myNum = (int)Level.High;
      Console.WriteLine(myNum);
        }


  }
}