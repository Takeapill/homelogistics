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
  public partial class FrmParticipants : Form
  {
    List<FamilyMember> members;
    public FrmParticipants()
    {
      InitializeComponent();
    }

    private void FrmParticipants_Load(object sender, EventArgs e)
    {
      members = Family.GetInstance().members;
      foreach (FamilyMember member in members)
      {
        dgvParticipants.Rows.Add(member.name);
      }
    }

    private void dgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 1)
      {
        if (dgvParticipants.Rows[e.RowIndex].Cells[1].Value == null)
        {
          dgvParticipants.Rows[e.RowIndex].Cells[1].Value = true;
        }
        else
        {
          dgvParticipants.Rows[e.RowIndex].Cells[1].Value = !(bool)dgvParticipants.Rows[e.RowIndex].Cells[1].Value;
        }
      } 
    }
  }
}
