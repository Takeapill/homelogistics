using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homelogistics
{
  public partial class FrmMeals : Form
  {
    static private FrmMeals instance;
    private List<Meal> meals = EventList.GetInstance().Meals; 
    private FrmMeals()
    {
      InitializeComponent();
    }

    static public FrmMeals getInstance()
    {
      if (instance == null || instance.IsDisposed)
      {
        instance = new FrmMeals();
      }
      return instance;
    }

    private void FrmMeals_Load(object sender, EventArgs e)
    {
      foreach (Meal meal in meals)
      {
        dgvTaches.Rows.Add(meal.ID, meal.Title, meal.Date, meal.Status);
      }
      
    }

    private void dgvTaches_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      FrmEventDesc frmEventDesc = new FrmEventDesc(meals[e.RowIndex].Title, meals[e.RowIndex].Description, meals[e.RowIndex].Date);
      frmEventDesc.ShowDialog();
    }
  }
}
