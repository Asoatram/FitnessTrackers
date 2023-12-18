using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackers.Resources
{
    public partial class MinimizeButton : UserControl
    {
        public MinimizeButton()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                // Minimize the parent form
                if (this.ParentForm != null)
                {
                    this.ParentForm.WindowState = FormWindowState.Minimized;
                }
            
        }
    }
}
