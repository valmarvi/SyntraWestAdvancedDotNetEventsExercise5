using System.Drawing;
using System.Windows.Forms;

namespace SyntraWestAdvancedDotNetEventsExercise5
{
    class Bucket : System.Windows.Forms.Form
    {
        public Bucket()
        {

        }

        public void FillBucket(object sender, object sender2, int status)
        {
            ((ProgressBar)sender).Value += ((ProgressBar)sender).Step;

            if (((ProgressBar)sender).Value < 0.8 * ((ProgressBar)sender).Maximum)
            {
                ((ProgressBar)sender).Value += ((ProgressBar)sender).Step;
            }
            else if (((ProgressBar)sender).Value >= 0.8 * ((ProgressBar)sender).Maximum && ((ProgressBar)sender).Value < ((ProgressBar)sender).Maximum)
            {
                ((Form)sender2).BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("The Bucket is Full");
            }
        }
    }
}
