using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YBS.Common.MsgBox
{
    public partial class frmNote : DevComponents.DotNetBar.Office2007Form
    {
        public frmNote()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getNote(string note)
        {
            this.txtNote.Text = note;
            this.ShowDialog();

            return txtNote.Text;
        }
    }
}
