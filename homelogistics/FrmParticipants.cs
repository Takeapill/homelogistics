using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace homelogistics
{
  public partial class FrmParticipants : Form
  {
    List<FamilyMember> members;
    internal Event Event { get; set; }
    internal FrmParticipants(Event @event)
    {
      InitializeComponent();
      Event = @event;
    }

    private void FrmParticipants_Load(object sender, EventArgs e)
    {
      members = Family.GetInstance().Members;
      foreach (FamilyMember member in members)
      {
        dgvParticipants.Rows.Add(member.name, Event.participants.Contains(member));
      }
    }

    private void DgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    private List<FamilyMember> GetParticipants()
    {
      List<FamilyMember> participants = new List<FamilyMember>();
      foreach (DataGridViewRow row in dgvParticipants.Rows)
      {
        if (row.Cells[1].Value != null && (bool)row.Cells[1].Value)
        {
          participants.Add(members[row.Index]);
        }
      }
      return participants;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Etes-vous sûr de vouloir modifier les participants?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
      if (result == DialogResult.OK)
      {
        Event.participants = GetParticipants();
        this.Close();
      }
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Vos modifications ne seront pas sauvegardées", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
      if (result == DialogResult.OK) this.Close();
    }
  }
}
