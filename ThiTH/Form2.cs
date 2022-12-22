using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void handleCancle(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void handleAccept(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
