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
    Event createdEvent;
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
      cmbType.DataSource = Enum.GetValues(typeof(EventType));
      cmbStatus.DataSource = Enum.GetValues(typeof(EventStatus));
    }

    private void BtnParticipants_Click(object sender, EventArgs e)
    {
      EventType eventType = (EventType)cmbType.SelectedItem;
      createdEvent = EventFactory.CreateEvent(eventType, txtNom.Text, rtxDesc.Text, dtpEvent.Value, new List<FamilyMember>());
      FrmParticipants frmParticipants = new FrmParticipants(createdEvent);
      frmParticipants.ShowDialog();
    }

    private void btnAjouter_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Voulez-vous sauvegarder cet événement?", "Add Event", MessageBoxButtons.YesNo);
      if (result == DialogResult.Yes)
      {
        if (createdEvent != null)
        {
          createdEvent.Title = txtNom.Text;
          createdEvent.Description = rtxDesc.Text;
          createdEvent.Date = dtpEvent.Value;
          createdEvent.Status = (EventStatus)cmbStatus.SelectedItem;
        }
        else
        {
          createdEvent = EventFactory.CreateEvent((EventType)cmbType.SelectedItem, txtNom.Text, rtxDesc.Text, dtpEvent.Value, new List<FamilyMember>());
        }
        EventList.GetInstance().AddEvent(createdEvent);
        MessageBox.Show("Evénement ajouté!", "Add Event", MessageBoxButtons.OK);
      }
      this.Close();
    }
  }
 }
