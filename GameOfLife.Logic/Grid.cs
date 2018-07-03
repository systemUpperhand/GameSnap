using System;
using System.Drawing;

namespace GameOfLife.Logic
{
  public class Grid
  {
    #region declarations
    private Cell[,] board;
    private Point size;
    private bool[,] nextGrid;
    #endregion
    public Grid(int widthOfPictureBox, int heightOfPictureBox)
    {
      Console.WriteLine(widthOfPictureBox + " " + heightOfPictureBox);
      size = new Point(widthOfPictureBox / (Cell.Size + 1), heightOfPictureBox / (Cell.Size + 1));
      board = new Cell[size.X, size.Y];
      nextGrid = new bool[size.X, size.Y];
      for (int i = 0; i < size.X; i++)
        for (int j = 0; j < size.Y; j++)
        {
          board[i, j] = new Cell(i + i * Cell.Size, j + j * Cell.Size);
          nextGrid[i, j] = false;
        }
    }

    public void Draw(Graphics graphics)
    {
      for (int i = 0; i < size.X; i++)
        for (int j = 0; j < size.Y; j++)
        {
          board[i, j].Draw(graphics);
        }
    }

    public void DrawUpdate(Point point, Graphics graphics)
    {
      int x = point.X / (Cell.Size + 1);
      int y = point.Y / (Cell.Size + 1);
      board[x, y].SwitchIsAlive();
      board[x, y].Draw(graphics);
    }

    private void SetNextState(Graphics graphics)
    {
      for (int i = 0; i < size.X; i++)
        for (int j = 0; j < size.Y; j++)
          if (board[i, j].isAlive != nextGrid[i, j])
          {
            board[i, j].isAlive = nextGrid[i, j];
            board[i, j].Draw(graphics);
          }
    }

    private int LivingNeighborsGet(int i, int j)
    {
      int count = 0;

      // right.
      if (i != size.X - 1)
        if (board[i + 1, j].isAlive)
          count++;

      // bottom right.
      if (i != size.X - 1 && j != size.Y - 1)
        if (board[i + 1, j + 1].isAlive)
          count++;

      // bottom.
      if (j != size.Y - 1)
        if (board[i, j + 1].isAlive)
          count++;

      // bottom left.
      if (i != 0 && j != size.Y - 1)
        if (board[i - 1, j + 1].isAlive)
          count++;

      // left.
      if (i != 0)
        if (board[i - 1, j].isAlive)
          count++;

      // top left.
      if (i != 0 && j != 0)
        if (board[i - 1, j - 1].isAlive)
          count++;

      // top
      if (j != 0)
        if (board[i, j - 1].isAlive)
          count++;

      // top right
      if (i != size.X - 1 && j != 0)
        if (board[i + 1, j - 1].isAlive)
          count++;

      return count;
    }

    private void ClearNextGrid()
    {
      for (int i = 0; i < size.X; i++)
        for (int j = 0; j < size.Y; j++)
          nextGrid[i, j] = false;
    }

    public void Update(Graphics graphics)
    {
      for (int i = 0; i < size.X; i++)
      {
        for (int j = 0; j < size.Y; j++)
        {
          bool living = board[i, j].isAlive;
          int countNeighbors = LivingNeighborsGet(i, j);

          if (!living && countNeighbors == 3)
          {
            nextGrid[i, j] = true;
          }
          else if (living && countNeighbors == 2 || countNeighbors == 3)
          {
            nextGrid[i, j] = true;
          }
          else if (living && countNeighbors > 3 || countNeighbors < 2)
          {
            nextGrid[i, j] = false;
          }
        }
      }
      SetNextState(graphics);
      ClearNextGrid();
    }

    public void RandomBoardCreate()
    {
      Random random = new Random();
      for (int i = 0; i < size.X; i++)
        for (int j = 0; j < size.Y; j++)
        {
          board[i, j].isAlive = Convert.ToBoolean(random.Next(2));
        }
    }
  }
}