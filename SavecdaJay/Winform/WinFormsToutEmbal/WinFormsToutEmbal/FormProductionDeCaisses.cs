using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsToutEmbal
{

    public partial class FormProductionDeCaisses : Form
    {

        public FormProductionDeCaisses()
        {
            InitializeComponent();
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabelDateTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormProductionDeCaisses_Load(object sender, EventArgs e)
        {

        }
    }
}
