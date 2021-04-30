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
using System.Windows.Input;

namespace SignalInterrupt
{
    public partial class Form1 : Form
    {
        Boolean turn = true;
        Boolean turn2 = true;

        public Form1()
        {
            InitializeComponent();
            buttonTask1Start.KeyPress += new KeyPressEventHandler(keyPressed);
            /*buttonTask2Start.KeyPress += new KeyPressEventHandler(KeyPress);
            buttonTask1Stop.KeyPress += new KeyPressEventHandler(KeyPress);
            buttonTask2Stop.KeyPress += new KeyPressEventHandler(KeyPress);*/
        }
        
        private void buttonTask1Start_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void buttonTask1Stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
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
            if (backgroundWorker2.IsBusy)
            {
                // Cancel the asynchronous operation.
                backgroundWorker2.CancelAsync();
            }
        }
        [STAThread]
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int x = 0; x < 10; x++)
            {
                if (turn)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (!backgroundWorker1.CancellationPending)
                        {
                            Thread.Sleep(50);
                            worker.ReportProgress(i);
                        }
                    }
                    turn = false;
                }
                else
                {
                    for (int i = 100; i > 0; i--)
                    {
                        if (!backgroundWorker1.CancellationPending)
                        {
                            Thread.Sleep(50);
                            worker.ReportProgress(i);
                        }
                    }
                    turn = true;
                }
            }
        }
        protected void task1Handler(object sender, ConsoleCancelEventArgs args)
        {
            if (backgroundWorker1.IsBusy)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarTask1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Process1 has been completed");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker2 = sender as BackgroundWorker;

            for (int j = 0; j < 10; j++)
            {
                if (turn2)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        if (!backgroundWorker2.CancellationPending)
                        {
                            Thread.Sleep(50);
                            worker2.ReportProgress(k);
                        }
                    }
                    turn2 = false;
                }
                else
                {
                    for (int k = 100; k > 0; k--)
                    {
                        if (!backgroundWorker2.CancellationPending)
                        {
                            Thread.Sleep(50);
                            worker2.ReportProgress(k);
                        }
                    }
                    turn2 = true;
                }
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            task2Progress.Text = e.ProgressPercentage + " %";
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Process2 has been completed");
        }

        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift && e.KeyChar == (char)Keys.Z)
            {
                if (backgroundWorker1.IsBusy)
                {
                    // Cancel the asynchronous operation.
                    backgroundWorker1.CancelAsync();
                }
            }
            if (Control.ModifierKeys == Keys.Shift && Keyboard.IsKeyDown(Key.A))
            {
                if (backgroundWorker2.IsBusy)
                {
                    // Cancel the asynchronous operation.
                    backgroundWorker2.CancelAsync();
                }
            }
            if (Control.ModifierKeys == Keys.Shift && Keyboard.IsKeyDown(Key.X))
            {
                if (!backgroundWorker1.IsBusy)
                {
                    // Cancel the asynchronous operation.
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            if (Control.ModifierKeys == Keys.Shift && Keyboard.IsKeyDown(Key.S))
            {
                if (!backgroundWorker2.IsBusy)
                {
                    // Cancel the asynchronous operation.
                    backgroundWorker2.RunWorkerAsync();
                }
            }
        }
    }
}
