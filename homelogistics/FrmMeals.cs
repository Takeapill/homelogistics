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
    private List<Meal> meals;
    private bool showAll = false;
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
      meals = showAll ? EventList.GetInstance().Meals : EventList.GetInstance().GetWeekMeals();
      lblMeals.Text = showAll ? "Tous les repas" : "Repas de la semaines";
      btnFilter.Text = showAll ? "Repas de la semaine" : "Tous les repas";
      dgvTaches.Rows.Clear();
      foreach (Meal meal in meals)
      {
          dgvTaches.Rows.Add(meal.ID, meal.Title, meal.Date.ToShortDateString(), meal.Status);
      }
      
    }

    private void dgvTaches_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1) return;
      FrmEventDesc frmEventDesc = new FrmEventDesc(EventList.GetInstance().Meals[e.RowIndex]);
      frmEventDesc.ShowDialog();
    }

    private void btnAll_Click(object sender, EventArgs e)
    {
      showAll = !showAll;
      FrmMeals_Load(sender, e);
    }
  }
}
