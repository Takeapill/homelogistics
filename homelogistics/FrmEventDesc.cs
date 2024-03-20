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
  public partial class FrmEventDesc : Form
  {
    public FrmEventDesc(string name, string desc, DateTime dateTime, string unitQty = "")
    {
      InitializeComponent();
      lblNom.Text += " " + name + " " + unitQty;
      rtxDesc.Text = desc;
      lblTextDate.Text += " " + dateTime.ToShortDateString();
    }
  }
}
