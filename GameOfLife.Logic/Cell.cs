using System.Drawing;

namespace GameOfLife.Logic
{
  public class Cell
  {
    
    public Point point { get; private set; }
    public Rectangle rectangle { get; private set; }
    public bool isAlive { get; set; }

    public static int Size = 9;

    public Cell(int x, int y)
    {
      point = new Point(x, y);
      rectangle = new Rectangle(x, y, Size, Size);

      isAlive = false;
    }

    public void Draw(System.Drawing.Graphics graphics)
    {
      if (isAlive)
        graphics.FillRectangle(new SolidBrush(Color.LimeGreen), rectangle);
      else
        graphics.FillRectangle(new SolidBrush(Color.Black), rectangle);
    }

    public void SwitchIsAlive()
    {
      if (isAlive)
        isAlive = false;
      else
        isAlive = true;
    }
  }
}