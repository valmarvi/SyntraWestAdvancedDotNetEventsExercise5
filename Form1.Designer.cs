
namespace SyntraWestAdvancedDotNetEventsExercise5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pgbFillingStatus = new System.Windows.Forms.ProgressBar();
            this.btnFillBucket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgbFillingStatus
            // 
            this.pgbFillingStatus.Location = new System.Drawing.Point(12, 161);
            this.pgbFillingStatus.Name = "pgbFillingStatus";
            this.pgbFillingStatus.Size = new System.Drawing.Size(452, 23);
            this.pgbFillingStatus.Step = 5;
            this.pgbFillingStatus.TabIndex = 0;
            // 
            // btnFillBucket
            // 
            this.btnFillBucket.Location = new System.Drawing.Point(189, 49);
            this.btnFillBucket.Name = "btnFillBucket";
            this.btnFillBucket.Size = new System.Drawing.Size(75, 68);
            this.btnFillBucket.TabIndex = 1;
            this.btnFillBucket.Text = "Fill Bucket";
            this.btnFillBucket.UseVisualStyleBackColor = true;
            this.btnFillBucket.Click += new System.EventHandler(this.btnFillBucket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 225);
            this.Controls.Add(this.btnFillBucket);
            this.Controls.Add(this.pgbFillingStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbFillingStatus;
        private System.Windows.Forms.Button btnFillBucket;
    }
}

