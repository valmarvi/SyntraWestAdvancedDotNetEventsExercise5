using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntraWestAdvancedDotNetEventsExercise5
{
    public partial class Form1 : Form
    {
        Bucket bucket = new Bucket();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFillBucket_Click(object sender, EventArgs e)
        {
            bucket.FillBucket(pgbFillingStatus, this, 10);
        }

        private void ShowStatus_AlarmTriggered(object sender, AlarmEventArgs e)
        {

        }
    }
}
