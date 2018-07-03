using GameOfLife.Logic;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GameOfLife
{
  public partial class frmMain : Form
  {
    #region declarations
    private ManualResetEvent _manualResetEvent = new ManualResetEvent(true);

    private bool isRunning = false;

    private bool isStarted = false;
    private Thread thread;
    private Grid grid;
    private int trackValue;
    private const int xMargin = 50;
    private const int yMargin = 125;
    private BufferedGraphics bGraphics;
    #endregion
    public frmMain()
    {
      InitializeComponent();

      trackValue = trackBar1.Value;

      this.MinimumSize = new Size(550, 200);
      thread = new Thread(new ThreadStart(this.GameStart));

    }

    #region UI Events
    private void btnStart_Click(object sender, EventArgs e)
    {
      btnDraw.Enabled = !btnDraw.Enabled;
      btnDraw.Enabled = !btnDraw.Enabled;
      if (isRunning)
      {
        btnStart.Text = "Start";
        isRunning = false;
        _manualResetEvent.Reset();
      }
      else
      {
        btnStart.Text = "Stop";
        isRunning = true;
        if (!isStarted)
        {
          thread.Start();
          isStarted = true;
        }
        else
        {
          _manualResetEvent.Set();
        }
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      GraphicsUpdate();

      grid = new Grid(int.Parse(XText.Text), int.Parse(YText.Text));

      grid.Draw(bGraphics.Graphics);
      bGraphics.Render();
      Canvas.Refresh();
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      CanvasInit();
    }
    
    private void btnDraw_Click(object sender, EventArgs e)
    {
      grid.Draw(bGraphics.Graphics);
      bGraphics.Render();
      btnStart.Enabled = true;
      btnClear.Enabled = true;
    }

    private void Canvas_MouseClick(object sender, MouseEventArgs e)
    {
      if (!isRunning)
      {
        grid.DrawUpdate(new Point(e.X, e.Y), bGraphics.Graphics);
        bGraphics.Render();
      }
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      trackValue = trackBar1.Value;
    }

    private void Text_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
        CanvasResize();
    }

    private void textCellSize_TextChanged(object sender, EventArgs e)
    {
      int size;
      if (int.TryParse(cellSizeText.Text, out size))
      {
        if (size > 0)
          Cell.Size = size;
        else
        {
          const string message = "Cell size have to be greater than 0";
          MessageBox.Show(message);
        }
      }
    }

    private void tmrLoad_Tick(object sender, EventArgs e)
    {
      tmrLoad.Enabled = false;
      CanvasInit();
    }

    private void btnRandom_Click(object sender, EventArgs e)
    {
      grid.RandomBoardCreate();
      grid.Draw(bGraphics.Graphics);
      bGraphics.Render();
      btnStart.Enabled = true;
      btnClear.Enabled = true;
    }

    protected override void OnClosed(EventArgs e)
    {
      thread.Abort();
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      if (!isStarted)
      {
        Canvas.Size = new Size(this.Size.Width - xMargin, this.Size.Height - yMargin);
        GraphicsUpdate();

        XText.Text = (this.Size.Width - xMargin).ToString();
        YText.Text = (this.Size.Height - yMargin).ToString();
      }
    }
    #endregion 
    private void CanvasInit()
    {
      createButton.Enabled = false;

      cellSizeText.Enabled = false;
      XText.Enabled = false;
      YText.Enabled = false;

      Canvas.Size = new Size(int.Parse(XText.Text), int.Parse(YText.Text));

      GraphicsUpdate();

      grid = new Grid(int.Parse(XText.Text), int.Parse(YText.Text));

      grid.Draw(bGraphics.Graphics);
      bGraphics.Render();
      Canvas.Refresh();

      Canvas.MouseClick += Canvas_MouseClick;

      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;

      
      btnRandom.Enabled = true;
      btnDraw.Enabled = true;
    }

    private void GameStart()
    {
      while (true)
      {
        grid.Update(bGraphics.Graphics);
        bGraphics.Render();
        Thread.Sleep(trackValue);
        _manualResetEvent.WaitOne(Timeout.Infinite);
      }
    }

    private void CanvasResize()
    {
      int a, b;
      if (int.TryParse(XText.Text, out a) && int.TryParse(YText.Text, out b))
      {
        this.Size = new Size(a + xMargin, b + yMargin);
      }
    }

    private void GraphicsUpdate()
    {
      BufferedGraphicsContext context = BufferedGraphicsManager.Current;
      bGraphics = context.Allocate(Canvas.CreateGraphics(), Canvas.DisplayRectangle);
    }


  }
}