namespace NewVsOverride
{
  class Sub : Base
  {
    // Forgot to include override keyword
    // public string Name => "Sub";
    public override string Name => "Sub";
  }
}