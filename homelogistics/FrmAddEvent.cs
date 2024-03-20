using System;
using System.CodeDom;
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
  public partial class FrmAddEvent : Form
  {
    public FrmAddEvent()
    {
      InitializeComponent();
    }

    public void SetSelectedDate(DateTime date)
    {
      dtpEvent.Value = date;
    }

    private void FrmAddEvent_Load(object sender, EventArgs e)
    {

    }

    private void BtnParticipants_Click(object sender, EventArgs e)
    {
      FrmParticipants frmParticipants = new FrmParticipants();
      frmParticipants.ShowDialog();
    }
  }
 }
