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
            foreach (var r in freqData)
            {
                chart1.Series[0].Points.AddXY(r.Key, r.Value);
            }
        }
    }
}
