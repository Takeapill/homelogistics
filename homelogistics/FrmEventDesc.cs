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
  internal partial class FrmEventDesc : Form
  {
    private readonly int currId;
    internal FrmEventDesc(Event e)
    {
      InitializeComponent();
      string unitQty = " ";
      if (e is ShopItem item) 
      {
        unitQty = item.UnitQty[0] + item.UnitQty[1];
      };

      LoadData(e.Title, e.Description, e.Date, unitQty);
      currId = e.ID;
    }

    private void FrmEventDesc_Load(object sender, EventArgs e)
    {
    }

    private void LoadData(string name, string desc, DateTime dateTime, string unitQty)
    {
      txtNom.Text = " " + name + " " + unitQty;
      rtxDesc.Text = desc;
      dtpDate.Value = dateTime;
      foreach (string stauts in Enum.GetNames(typeof(EventStatus)))
      {
        cmbStatus.Items.Add(stauts);
      }
    }

    private void BtnNoSave_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Vos modifications ne seront pas sauvegardées", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
      if (result == DialogResult.OK) this.Close();
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Etes-vous sûr de vouloir modifier les données?", "Sauvegarde", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
      if (result == DialogResult.OK)
      {
        ModifyData(currId);
        this.Close();
      }
    }

    private void ModifyData(int id)
    {
      Event e = EventList.GetInstance().Events.Find(x => x.ID == id);
      e.Title = txtNom.Text;
      e.Description = rtxDesc.Text;
      e.Date = dtpDate.Value;
    }

    private void BtnParticipants_Click(object sender, EventArgs e)
    {
      Event @event = EventList.GetInstance().Events.Find(x => x.ID == currId);
      FrmParticipants frmParticipants = new FrmParticipants(@event);
      frmParticipants.ShowDialog();
    }
  }
}
