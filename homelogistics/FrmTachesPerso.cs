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
  public partial class FrmTachesPerso : Form
  {
    static public FrmTachesPerso instance;
    private FrmTachesPerso()
    {
      InitializeComponent();
    }

    static public FrmTachesPerso getInstance()
    {
      if (instance == null)
      {
        instance = new FrmTachesPerso();
      }
      return instance;
    } 
  }
}
