using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZavrsnaApk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void upisNovihPolagacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpis upis = new FormUpis();
            upis.Show();
        }

        private void ispitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ispit = new FormIspit();
            ispit.Show();
        }

        private void izlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var messageBox = MessageBox.Show("Da li ste sigurni da želite zatvoriti aplikaciju ", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (messageBox == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
