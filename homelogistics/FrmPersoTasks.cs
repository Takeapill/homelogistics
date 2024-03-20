using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace homelogistics
{
  public partial class FrmPersoTasks : Form
  {
    static private FrmPersoTasks instance;
    private static List<Task> events = EventList.GetInstance().Tasks;
    private FrmPersoTasks()
    {
      InitializeComponent();
    }

    static public FrmPersoTasks GetInstance()
    {
      if (instance == null || instance.IsDisposed)
      {
        instance = new FrmPersoTasks();
      }
      return instance;
    }

    private void FrmPersoTasks_Load(object sender, EventArgs e)
    {
      foreach (Event es in events)
      {
        dgvTaches.Rows.Add(es.ID, es.Title, es.Date, es.Status);
      }
    }

    private void dgvTaches_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      Console.WriteLine(e.RowIndex);
      FrmEventDesc frmEventDesc = new FrmEventDesc(events[e.RowIndex].Title, events[e.RowIndex].Description, events[e.RowIndex].Date);
      frmEventDesc.ShowDialog();
    }
  }
}
