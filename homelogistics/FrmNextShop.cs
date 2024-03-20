using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace homelogistics
{
  internal partial class FrmNextShop : Form
  {
    internal static FrmNextShop instance;
    private List<ShopItem> shoppingList = EventList.GetInstance().GetNextShoppingList();
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
      shoppingList = EventList.GetInstance().GetNextShoppingList();
      lblDate.Text = shoppingList[0].Date.ToString("dd/MM/yyyy");
      foreach (ShopItem item in shoppingList)
      {
        if (item.Status != "Done")
        {
          dgvTaches.Rows.Add(item.ID, item.Title);
        }
      }
    }

    private void btnAll_Click(object sender, EventArgs e)
    {

    }

    private void dgvTaches_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 1)
      {
        ShopItem item = shoppingList[e.RowIndex];
        string unitQty = item.GetUnitQty();
        FrmEventDesc frmEventDesc = new FrmEventDesc(item.Title, item.Description, item.Date, unitQty);
        frmEventDesc.ShowDialog();
      }
      else if (e.ColumnIndex == 2)
      {
      }
    }

    private void dgvTaches_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

      if (e.ColumnIndex == 2)
      {
        if (dgvTaches.Rows[e.RowIndex].Cells[2].Value == null)
        {
          dgvTaches.Rows[e.RowIndex].Cells[2].Value = true;
        }
        else
        {
          dgvTaches.Rows[e.RowIndex].Cells[2].Value = !(bool)dgvTaches.Rows[e.RowIndex].Cells[2].Value;
        }
      } 
    }

    private void btnDone_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgvTaches.Rows)
      {
        if (row.Cells[2].Value != null && (bool)row.Cells[2].Value)
        {
          shoppingList[row.Index].Status = "Done";
        }
      }
      dgvTaches.Rows.Clear();
      FrmNextShop_Load(sender, e);
    }
  }
}
