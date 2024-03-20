using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace homelogistics
{
  public partial class FrmNextShop : Form
  {
    public static FrmNextShop instance;
    private List<ShopItem> shoppingList = EventList.GetInstance().GetNextShoppingList();
    private FrmNextShop()
    {
      InitializeComponent();
    }

    public static FrmNextShop getInstance()
    {
      if (instance == null || instance.IsDisposed)
      {
        instance = new FrmNextShop();
      }
      return instance;
    }

    private void FrmNextShop_Load(object sender, EventArgs e)
    {
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
        shoppingList[e.RowIndex].Status = "Done";
        dgvTaches.Rows.Clear();
        FrmNextShop_Load(sender, e);
      }
    }
  }
}
