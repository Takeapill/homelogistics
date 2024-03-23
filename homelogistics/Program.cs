using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homelogistics
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Family.GetInstance();
      EventList.GetInstance();
      EventList.GetInstance().LoadEvents();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      FrmLogin frmLogin = new FrmLogin();
      if (frmLogin.ShowDialog() == DialogResult.OK)
      {
        Application.Run(FrmEvents.getInstance());
      }
      Application.Exit();
    }
  }
}
