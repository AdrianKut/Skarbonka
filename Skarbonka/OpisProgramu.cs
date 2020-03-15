using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarbonka
{
    public partial class OpisProgramu : Form
    {
      
        public OpisProgramu()
        {
            InitializeComponent();
            
        }   

        private void OpisProgramu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Hide();
            }
        }

        private void OpisProgramu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
