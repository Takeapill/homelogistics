using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace homelogistics
{
  public partial class FrmParticipants : Form
  {
    List<FamilyMember> members;
    Event ev;
    internal FrmParticipants(Event @event)
    {
      InitializeComponent();
      ev = @event;
    }

    private void FrmParticipants_Load(object sender, EventArgs e)
    {
      members = Family.GetInstance().Members;
      foreach (FamilyMember member in members)
      {
        dgvParticipants.Rows.Add(member.ID, member.Name, ev.participants.Contains(member));
      }
    }

    private void DgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 2)
      {
        if (dgvParticipants.Rows[e.RowIndex].Cells[2].Value == null)
        {
          dgvParticipants.Rows[e.RowIndex].Cells[2].Value = true;
        }
        else
        {
          dgvParticipants.Rows[e.RowIndex].Cells[2].Value = !(bool)dgvParticipants.Rows[e.RowIndex].Cells[2].Value;
        }
      }
    }
    private List<FamilyMember> GetParticipants()
    {
      List<FamilyMember> participants = new List<FamilyMember>();
      foreach (DataGridViewRow row in dgvParticipants.Rows)
      {
        if (row.Cells[2].Value != null && (bool)row.Cells[2].Value)
        {
          participants.Add(members[(int)row.Cells[0].Value -1]);
        }
      }
      return participants;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Etes-vous sûr de vouloir modifier les participants?", "Sauvegarde", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
      if (result == DialogResult.OK)
      {
        ev.participants = GetParticipants();
        this.Close();
      }
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Vos modifications ne seront pas sauvegardées", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
      if (result == DialogResult.OK) this.Close();
    }
  }
}
