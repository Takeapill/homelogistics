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
  public partial class FrmLogin : Form
  {
    public FrmLogin()
    {
      InitializeComponent();
    }

    private void Login_Load(object sender, EventArgs e)
    {

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      FamilyMember member = Family.GetInstance().Members.Find(x => x.Username == txtUsername.Text);
      if (member.VerifyPassword(txtPassword.Text))
      {
        MessageBox.Show("Login successful");
        this.DialogResult = DialogResult.OK;
        Family.GetInstance().CurrentUser = member;
      }
      else
      {
        MessageBox.Show("Invalid username or password");
        this.DialogResult = DialogResult.Cancel;
      }
    }
  }
}
