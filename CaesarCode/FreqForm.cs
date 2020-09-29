using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCode
{
    public partial class FreqForm : Form
    {
        private Dictionary<string, double> otfreq;
        private Dictionary<string, double> ctfreq;
        public FreqForm(Dictionary<string, double> otfreq, Dictionary<string, double> ctfreq)
        {
            this.otfreq = otfreq;
            this.ctfreq = ctfreq;
            InitializeComponent();
        }

        private void freq_Load(object sender, EventArgs e)
        {
            foreach (var d in otfreq)
            {
                chart1.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }
            foreach(var d in ctfreq)
            {
                chart1.Series["Series2"].Points.AddXY(d.Key, d.Value);
            }
        }
    }
}
