class Cell
{
  public string Contents { get; set; }
}
Cell[][] sheet = new Cell[100][];
// sheet;
sheet[0] = new Cell[10];
// sheet;

for(int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
{
  sheet[rowIndex] = new Cell[10]; // Create a row of 10 cells
  for(int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
  {
    sheet[rowIndex][colIndex] = new Cell();
  }
}
sheet;
sheet[4][7];
foreach (Cell[] row in sheet)
{
  foreach (Cell cell in row)
  {
    System.Console.Write(cell);
  }
  System.Console.WriteLine();
}
sheet[4] = new Cell[13];

// namespace Treehouse.CodeChallenges
// {
//     public static class MathHelpers
//     {
//         public static int[][] BuildMultiplicationTable(int maxFactor)
//         {
//             int[][] arr = new int[maxFactor + 1][];
//             for(int rowIndex = 0; rowIndex < arr.Length; rowIndex++)
//             {
//               arr[rowIndex] = new int[maxFactor + 1];
//               for(int colIndex = 0; colIndex < arr[rowIndex].Length; colIndex++)
//               {
//                 arr[rowIndex][colIndex] = rowIndex * colIndex;
//               }
//             }
//             return arr;
//         }
//     }
// }
