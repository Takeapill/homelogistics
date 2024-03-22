using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace homelogistics
{
  public partial class FrmPersoTasks : Form
  {
    static private FrmPersoTasks instance;
    private bool showAll = false;
    private static List<Event> events;
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
      btnFilter.Text = showAll ? "Vos tâches" : "Toutes les tâches";
      lblTasks.Text = showAll ? "Les tâches" : "Vos tâches";
      dgvTaches.Rows.Clear();
      events = showAll ? EventList.GetInstance().GetEventsByType(EventType.Task) 
        : EventList.GetInstance().GetCurrentUserEventsByType(EventType.Task);
      foreach (Event es in events)
      {
        dgvTaches.Rows.Add(es.ID, es.Title, es.Date, es.Status);
      }
    }

    private void dgvTaches_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        FrmEventDesc frmEventDesc = new FrmEventDesc(events[e.RowIndex]);
        frmEventDesc.ShowDialog();
      }
    }

    private void btnAll_Click(object sender, EventArgs e)
    {
      showAll = !showAll;
      FrmPersoTasks_Load(sender, e);
    }
  }
}
