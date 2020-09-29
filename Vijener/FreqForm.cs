using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vijener
{
    public partial class FreqForm : Form
    {
        private string text;
        public FreqForm(string t)
        {
            InitializeComponent();
            text = t;
        }

        private void freq_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY("f", 2);
        }
    }
}
