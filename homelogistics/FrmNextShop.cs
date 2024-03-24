using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace homelogistics
{
  internal partial class FrmNextShop : Form
  {
    internal static FrmNextShop instance;
    private List<ShopItem> shoppingList;
    private bool showAll = false;
    private FrmNextShop()
    {
      InitializeComponent();
    }

    internal static FrmNextShop getInstance()
    {
      if (instance == null || instance.IsDisposed)
      {
        instance = new FrmNextShop();
      }
      return instance;
    }

    private void FrmNextShop_Load(object sender, EventArgs e)
    {
      shoppingList = showAll ? EventList.GetInstance().ShopItems : EventList.GetInstance().GetNextShoppingList();
      btnFilter.Text = showAll ? "tout" : "semaine";
      lblCourses.Text = showAll ? "Toutes les courses" : "Courses de la semaine";
      if (shoppingList.Count == 0)
      {
        MessageBox.Show("Aucune liste de courses trouvée");
        return;
      }
      lblTextDate.Text = showAll ? "" : "Date: " + shoppingList[0].Date.ToString("dd/MM/yyyy");
      dgvTaches.Rows.Clear();
      foreach (ShopItem item in shoppingList)
      {
        if (item.Status != EventStatus.Done)
        {
          dgvTaches.Rows.Add(item.ID, item.Title);
        }
      }
    }

    private void BtnAll_Click(object sender, EventArgs e)
    {
      showAll = !showAll;
      FrmNextShop_Load(sender, e);
    }

    private void DgvTaches_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1) return;
      if (e.ColumnIndex == 1)
      {
        ShopItem item = shoppingList[e.RowIndex];
        FrmEventDesc frmEventDesc = new FrmEventDesc(item);
        frmEventDesc.ShowDialog();
      }
      else if (e.ColumnIndex == 2)
      {
      }
    }

    private void DgvTaches_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 2 && e.RowIndex >= 0)
      {
        DataGridViewCell cell = dgvTaches.Rows[e.RowIndex].Cells[e.ColumnIndex];
        if (cell.Value == null)
        {
          cell.Value = true;
        }
        else
        {
          cell.Value = !(bool)cell.Value;
        }
      }
    }

    private void btnDone_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgvTaches.Rows)
      {
        int idx = row.Index;
        if (row.Cells[2].Value != null && (bool)row.Cells[2].Value)
        {
          shoppingList[idx].Status = EventStatus.Done;
        }
      }
      dgvTaches.Rows.Clear();
      FrmNextShop_Load(sender, e);
    }
  }
}
