class Cell
{
  public string Contents { get; set; }
}

Cell[,] sheet = new Cell[100, 10];
sheet.Length;
sheet[0,0];

for(int rowIndex = 0; rowIndex < sheet.GetLength(0); rowIndex++)
{
  for(int colIndex = 0; colIndex < sheet.GetLength(1); colIndex++)
  {
    sheet[rowIndex,colIndex] = new Cell();
  }
}
sheet[2,3];