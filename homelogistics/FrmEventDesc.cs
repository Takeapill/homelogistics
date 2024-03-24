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
    private Event ev;
    internal FrmEventDesc(Event e)
    {
      InitializeComponent();

      ev = e;
    }

    private void FrmEventDesc_Load(object sender, EventArgs e)
    {
      string unitQty = " ";
      if (ev is ShopItem item) 
      {
        unitQty = item.UnitQty[0] + item.UnitQty[1];
      };

      LoadData(ev.Title, ev.Description, ev.Date, ev.Status, unitQty);
    }

    private void LoadData(string name, string desc, DateTime dateTime, EventStatus status, string unitQty)
    {
      txtNom.Text = " " + name + " " + unitQty;
      rtxDesc.Text = desc;
      dtpDate.Value = dateTime;
      foreach (string stauts in Enum.GetNames(typeof(EventStatus)))
      {
        cmbStatus.Items.Add(stauts);
      }
      cmbStatus.SelectedItem = status.ToString();
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
        ModifyData();
        FrmEventDesc_Load(sender, e);
        this.Close();
      }
    }

    private void ModifyData()
    {
      ev.Title = txtNom.Text;
      ev.Description = rtxDesc.Text;
      ev.Date = dtpDate.Value;
      ev.Status = (EventStatus)Enum.Parse(typeof(EventStatus), cmbStatus.SelectedItem.ToString());
    }

    private void BtnParticipants_Click(object sender, EventArgs e)
    {
      FrmParticipants frmParticipants = new FrmParticipants(ev);
      frmParticipants.ShowDialog();
    }
  }
}
