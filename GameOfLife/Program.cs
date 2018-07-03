using System;
using System.Windows.Forms;

namespace GameOfLife
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      frmMain form1 = new frmMain();

      form1.Text = "Game of life";
      Application.Run(form1);
    }
  }
}