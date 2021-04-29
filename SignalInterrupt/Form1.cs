using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SignalInterrupt
{
    public partial class Form1 : Form
    {
        int i = 0;
        Boolean turn = true;
        int j = 0;
        Boolean turn2 = true;
        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int x = 0; x < 100; x++)
            {
                if (turn)
                {
                    Thread.Sleep(500);
                    worker.ReportProgress(i);
                    i++;
                    if (i == 101) turn = false;
                }
                else
                {
                    Thread.Sleep(500);
                    worker.ReportProgress(i);
                    i--;
                    if (i == -1) turn = true;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarTask1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker2 = sender as BackgroundWorker;
            while (true)
            {
                if (turn2)
                {
                    Thread.Sleep(500);
                    worker2.ReportProgress(j);
                    j++;
                    if (j == 101) turn2 = false;
                }
                else
                {
                    Thread.Sleep(500);
                    worker2.ReportProgress(j);
                    j--;
                    if (j == -1) turn2 = true;
                }
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            trackBarTask2.Value = e.ProgressPercentage;
        }

        private void buttonTask1Start_Click(object sender, EventArgs e)
        {
            progressBarTask1.Value = 50;
            if (!backgroundWorker1.IsBusy)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void buttonTask1Stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        private void buttonTask2Start_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker2.IsBusy)
            {
                // Start the asynchronous operation.
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void buttonTask2Stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker2.CancelAsync();
            }
        }
    }
}
