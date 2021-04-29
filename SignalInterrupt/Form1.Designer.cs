
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTask2Stop = new System.Windows.Forms.Button();
            this.buttonTask2Start = new System.Windows.Forms.Button();
            this.trackBarTask2 = new System.Windows.Forms.TrackBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTask2)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(289, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task 1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(163, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shift + z";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shift + x";
            // 
            // buttonTask1Stop
            // 
            this.buttonTask1Stop.Location = new System.Drawing.Point(166, 40);
            this.buttonTask1Stop.Name = "buttonTask1Stop";
            this.buttonTask1Stop.Size = new System.Drawing.Size(101, 49);
            this.buttonTask1Stop.TabIndex = 3;
            this.buttonTask1Stop.Text = "Stop";
            this.buttonTask1Stop.UseVisualStyleBackColor = true;
            this.buttonTask1Stop.Click += new System.EventHandler(this.buttonTask1Stop_Click);
            // 
            // buttonTask1Start
            // 
            this.buttonTask1Start.Location = new System.Drawing.Point(19, 40);
            this.buttonTask1Start.Name = "buttonTask1Start";
            this.buttonTask1Start.Size = new System.Drawing.Size(101, 49);
            this.buttonTask1Start.TabIndex = 2;
            this.buttonTask1Start.Text = "Start";
            this.buttonTask1Start.UseVisualStyleBackColor = true;
            this.buttonTask1Start.Click += new System.EventHandler(this.buttonTask1Start_Click);
            // 
            // progressBarTask1
            // 
            this.progressBarTask1.Location = new System.Drawing.Point(19, 172);
            this.progressBarTask1.Name = "progressBarTask1";
            this.progressBarTask1.Size = new System.Drawing.Size(248, 137);
            this.progressBarTask1.Step = 2;
            this.progressBarTask1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonTask2Stop);
            this.groupBox2.Controls.Add(this.buttonTask2Start);
            this.groupBox2.Controls.Add(this.trackBarTask2);
            this.groupBox2.Location = new System.Drawing.Point(346, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 329);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(134, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shift + a";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(134, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shift + s";
            // 
            // buttonTask2Stop
            // 
            this.buttonTask2Stop.Location = new System.Drawing.Point(137, 150);
            this.buttonTask2Stop.Name = "buttonTask2Stop";
            this.buttonTask2Stop.Size = new System.Drawing.Size(101, 49);
            this.buttonTask2Stop.TabIndex = 5;
            this.buttonTask2Stop.Text = "Stop";
            this.buttonTask2Stop.UseVisualStyleBackColor = true;
            this.buttonTask2Stop.Click += new System.EventHandler(this.buttonTask2Stop_Click);
            // 
            // buttonTask2Start
            // 
            this.buttonTask2Start.Location = new System.Drawing.Point(137, 40);
            this.buttonTask2Start.Name = "buttonTask2Start";
            this.buttonTask2Start.Size = new System.Drawing.Size(101, 49);
            this.buttonTask2Start.TabIndex = 4;
            this.buttonTask2Start.Text = "Start";
            this.buttonTask2Start.UseVisualStyleBackColor = true;
            this.buttonTask2Start.Click += new System.EventHandler(this.buttonTask2Start_Click);
            // 
            // trackBarTask2
            // 
            this.trackBarTask2.Location = new System.Drawing.Point(41, 40);
            this.trackBarTask2.Maximum = 100;
            this.trackBarTask2.Name = "trackBarTask2";
            this.trackBarTask2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTask2.Size = new System.Drawing.Size(56, 269);
            this.trackBarTask2.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTask2)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBarTask2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

