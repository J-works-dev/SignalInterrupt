
namespace SignalInterrupt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTask1Stop = new System.Windows.Forms.Button();
            this.buttonTask1Start = new System.Windows.Forms.Button();
            this.progressBarTask1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.task2Progress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTask2Stop = new System.Windows.Forms.Button();
            this.buttonTask2Start = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTask1Stop);
            this.groupBox1.Controls.Add(this.buttonTask1Start);
            this.groupBox1.Controls.Add(this.progressBarTask1);
            this.groupBox1.Location = new System.Drawing.Point(32, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task 1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(149, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shift + z";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shift + x";
            // 
            // buttonTask1Stop
            // 
            this.buttonTask1Stop.Location = new System.Drawing.Point(152, 200);
            this.buttonTask1Stop.Name = "buttonTask1Stop";
            this.buttonTask1Stop.Size = new System.Drawing.Size(101, 49);
            this.buttonTask1Stop.TabIndex = 3;
            this.buttonTask1Stop.Text = "Stop";
            this.buttonTask1Stop.UseVisualStyleBackColor = true;
            this.buttonTask1Stop.Click += new System.EventHandler(this.buttonTask1Stop_Click);
            // 
            // buttonTask1Start
            // 
            this.buttonTask1Start.Location = new System.Drawing.Point(19, 200);
            this.buttonTask1Start.Name = "buttonTask1Start";
            this.buttonTask1Start.Size = new System.Drawing.Size(101, 49);
            this.buttonTask1Start.TabIndex = 2;
            this.buttonTask1Start.Text = "Start";
            this.buttonTask1Start.UseVisualStyleBackColor = true;
            this.buttonTask1Start.Click += new System.EventHandler(this.buttonTask1Start_Click);
            // 
            // progressBarTask1
            // 
            this.progressBarTask1.Location = new System.Drawing.Point(19, 40);
            this.progressBarTask1.Name = "progressBarTask1";
            this.progressBarTask1.Size = new System.Drawing.Size(234, 86);
            this.progressBarTask1.Step = 2;
            this.progressBarTask1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.task2Progress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonTask2Stop);
            this.groupBox2.Controls.Add(this.buttonTask2Start);
            this.groupBox2.Location = new System.Drawing.Point(332, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 329);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task2";
            // 
            // task2Progress
            // 
            this.task2Progress.AutoSize = true;
            this.task2Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task2Progress.ForeColor = System.Drawing.Color.Lime;
            this.task2Progress.Location = new System.Drawing.Point(105, 64);
            this.task2Progress.Name = "task2Progress";
            this.task2Progress.Size = new System.Drawing.Size(0, 44);
            this.task2Progress.TabIndex = 7;
            this.task2Progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(154, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shift + a";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shift + s";
            // 
            // buttonTask2Stop
            // 
            this.buttonTask2Stop.Location = new System.Drawing.Point(157, 200);
            this.buttonTask2Stop.Name = "buttonTask2Stop";
            this.buttonTask2Stop.Size = new System.Drawing.Size(101, 49);
            this.buttonTask2Stop.TabIndex = 5;
            this.buttonTask2Stop.Text = "Stop";
            this.buttonTask2Stop.UseVisualStyleBackColor = true;
            this.buttonTask2Stop.Click += new System.EventHandler(this.buttonTask2Stop_Click);
            // 
            // buttonTask2Start
            // 
            this.buttonTask2Start.Location = new System.Drawing.Point(27, 200);
            this.buttonTask2Start.Name = "buttonTask2Start";
            this.buttonTask2Start.Size = new System.Drawing.Size(101, 49);
            this.buttonTask2Start.TabIndex = 4;
            this.buttonTask2Start.Text = "Start";
            this.buttonTask2Start.UseVisualStyleBackColor = true;
            this.buttonTask2Start.Click += new System.EventHandler(this.buttonTask2Start_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTask1Stop;
        private System.Windows.Forms.Button buttonTask1Start;
        private System.Windows.Forms.ProgressBar progressBarTask1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTask2Stop;
        private System.Windows.Forms.Button buttonTask2Start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label task2Progress;
    }
}

