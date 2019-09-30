namespace Animal
{
  class Program
  {
    public static void Main()
    {
      Bird bird = new Bird();
      bird.Move();

      Penguin penguin = new Penguin();
      penguin.Move();

      Bird penguinBird = new Penguin();
      penguinBird.Move();
    }
  }
}