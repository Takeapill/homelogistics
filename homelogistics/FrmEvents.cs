using System;
using System.Windows.Forms;

namespace homelogistics
{
  public partial class FrmEvents : Form
  {
    static FrmEvents instance;
    private FrmEvents() => InitializeComponent();

    static public FrmEvents getInstance()
    {
      if (instance == null)
      {
        instance = new FrmEvents();
      }
      return instance;
    }
    private void btnTaches_Click(object sender, EventArgs e)
    {   
      FrmPersoTasks frmPersoTasks = FrmPersoTasks.GetInstance();
      frmPersoTasks.Show();
    }

    private void cdrEvents_DateChanged(object sender, DateRangeEventArgs e)
    {
      FrmAddEvent frmAddEvent = new FrmAddEvent();
      frmAddEvent.SetSelectedDate(e.Start);
      frmAddEvent.Show();
    }

    private void btnCourses_Click(object sender, EventArgs e)
    {
      FrmNextShop frmNextShop = FrmNextShop.getInstance();
      frmNextShop.Show();
    }

    private void btnRepas_Click(object sender, EventArgs e)
    {
      FrmMeals frmMeals = FrmMeals.getInstance();
      frmMeals.Show();
    }
  }
}
