namespace NewVsOverride
{
  class Program
  {
    public static void Main()
    {
      Base b = new Base();
      System.Console.WriteLine(b.Name);
      Sub s = new Sub();
      System.Console.WriteLine(s.Name);
      Base b2 = new Sub();
      System.Console.WriteLine(b2.Name);
    }
  }
}