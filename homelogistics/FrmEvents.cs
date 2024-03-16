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
      FrmTachesPerso frmTaches = FrmTachesPerso.getInstance();
      frmTaches.Show();
    }
  }
}
